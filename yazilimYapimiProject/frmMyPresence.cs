using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;

namespace yazilimYapimiProject
{
    public partial class frmMyPresence : Form
    {
        public frmMyPresence(User user)
        {
            InitializeComponent();
            this.us = user;
        }

        readonly User us = new User();
        readonly SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3PS3P83\\BERKCANSERVER;Initial Catalog=yazilimYapimi;Integrated Security=True");

        void Restart()//When a item is sold changed this will start
        {
            FrmLoad();
        }

        void FillDGV()
        {

            SqlCommand commandShow = new SqlCommand
            {
                Connection = connection,
                CommandText = "ShowUserProducts "+ us.UserID
            };
            SqlDataAdapter adapt = new SqlDataAdapter(commandShow);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dgvMyProducts.DataSource = dt;

        }
        void ShowMoney()
        {
            SqlCommand commandShowMoney = new SqlCommand
            {
                Connection = connection,
                CommandText = "Select MoneyAmount from tbl_Moneys where UserID= " + us.UserID
            };
            SqlDataReader dr = commandShowMoney.ExecuteReader();
            dr.Read();

            if(!dr.HasRows)
            {
                lblMoney.Text = "0 ₺";
            }
            else 
            {
            lblMoney.Text = dr.GetValue(0) + " ₺";
            }
            dr.Close();
        }
        void FillCbb()
        {
            SqlCommand commandFillCbb = new SqlCommand
            {
                Connection = connection,
                CommandText = "Select ItemName from tbl_Items"
            };

            SqlDataReader dr2 = commandFillCbb.ExecuteReader();
            while (dr2.Read())
            {
                cbbAddProduct.Items.Add(dr2["ItemName"].ToString());

            }

        }
        void FrmLoad()
        {
            cbbMoney.SelectedIndex = 0;
            txtMoney.Text = "0";
            ShowTurkishLira();
            connection.Open();
            FillDGV();//Show info from tbl_UserItems
            ShowMoney();//Show money in label from tbl_Moneys
            FillCbb();//Fill the combobox from tbl_Items
            connection.Close();
        }
        private void frmMyPresence_Load(object sender, EventArgs e)
        {
            FrmLoad();
        }
        void Sell()
        {
            string itemID = dgvMyProducts.SelectedCells[1].Value.ToString();
            connection.Open();
            SqlCommand commandSell = new SqlCommand
            {
                Connection = connection,
                CommandText = "Execute SellProduct " + us.UserID + "," + itemID + "," + txtAmount.Text + "," + txtPrice.Text +
                " Execute DeleteProduct " + us.UserID + ", " + itemID + ", " + txtAmount.Text
            };
            if (Convert.ToInt32(dgvMyProducts.SelectedCells[3].Value.ToString()) < Convert.ToInt32(txtAmount.Text))
            {
                MessageBox.Show("The entered amount should not be more than the selected product quantity.", "Warning");
                connection.Close();
            }
            else
            {
                MessageBox.Show("Product is sold.", "Success");
                commandSell.ExecuteNonQuery();
                connection.Close();
                Restart();
            }
        }
        void AddProduct()
        {
            connection.Open();
            int item = cbbAddProduct.SelectedIndex + 1;
            SqlCommand commandAP = new SqlCommand
            {
                Connection = connection,
                CommandText = "Execute AddProductRequest " + us.UserID + ", " + item + ", " + Convert.ToInt32(txtAddProduct.Text)
            };
            commandAP.ExecuteNonQuery();
            MessageBox.Show("The request has been sent.", "Request");
            cbbAddProduct.ResetText();
            txtAddProduct.ResetText();
            connection.Close();
        }
        decimal returnCurrencyRate(int currencyUnit)//Multiplys the currency rate.
        {
            String URLString = "https://www.tcmb.gov.tr/kurlar/today.xml";//URL
            XmlTextReader reader = new XmlTextReader(URLString);//Creating reader
            decimal multiplier = 0;//Creating multiplier

            if (currencyUnit==0)//If Turkish Lira
            {
                return 1;
            }
            else//If Another currency unit
            { 
                XmlDocument xml = new XmlDocument();
                xml.Load(URLString);
                multiplier= Convert.ToDecimal(xml.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{"+(currencyUnit-1)+"}']/ForexBuying", "USD","AUD", "DKK", "EUR","GBP")).InnerText.Replace('.', ','));
                return multiplier;
            }
        }
        void ShowTurkishLira()
        {
            decimal amount = returnCurrencyRate(cbbMoney.SelectedIndex) * Convert.ToInt32(txtMoney.Text);
            lblTL.Text = "= " + amount.ToString() + " ₺";
        }
        void AddMoney()
        {
            connection.Open();
            SqlCommand commandAddMoney = new SqlCommand//Add Money request multiplied with currency rate
            {
                Connection = connection,
                CommandText = "insert into tbl_MoneyRequests(UserID,Amount) values (" + us.UserID + ", " + Convert.ToInt32(txtMoney.Text)*returnCurrencyRate(cbbMoney.SelectedIndex) + ")"
            };
            commandAddMoney.ExecuteNonQuery();
            MessageBox.Show("The request has been sent.", "Request");
            txtMoney.ResetText();
            connection.Close();
        }
        private void BtnSell_Click(object sender, EventArgs e)
        {
            Sell();
        }
        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct();
        }
        private void BtnAddMoney_Click(object sender, EventArgs e)
        {
            AddMoney();
        }
        private void txtMoney_TextChanged(object sender, EventArgs e)//Shows multiplier to Turkish Lira when label changed
        {
            if (txtMoney.Text == "")
                txtMoney.Text = "0";
            ShowTurkishLira();
        }
        private void cbbMoney_SelectedIndexChanged(object sender, EventArgs e)//Shows multiplier to Turkish Lira when cbb changed
        {
            ShowTurkishLira();
        }
    }
}