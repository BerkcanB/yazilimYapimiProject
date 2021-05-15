using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace yazilimYapimiProject
{
    public partial class frmMarket : Form
    {
        public frmMarket(User user)
        {
            us = user;
            InitializeComponent();
        }
        private void frmMarket_Load(object sender, EventArgs e)
        {
            FrmLoad();
        }

        readonly User us = new User();
        readonly SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3PS3P83\\BERKCANSERVER;Initial Catalog=yazilimYapimi;Integrated Security=True");

        void FillDGV()
        {

            SqlCommand commandShow = new SqlCommand
            {
                Connection = connection,
                CommandText = "Execute ShowMarketProducts " 
            };
            SqlDataAdapter adapt = new SqlDataAdapter(commandShow);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dgvMarket.DataSource = dt;

        }//Fills the datagridview with market products
        void ShowMoney()
        {
            SqlCommand commandShowMoney = new SqlCommand
            {
                Connection = connection,
                CommandText = "Select MoneyAmount from tbl_Moneys where UserID= " + us.UserID
            };
            SqlDataReader dr = commandShowMoney.ExecuteReader();
            dr.Read();

            if (!dr.HasRows)
            {
                int money = 0;
                lblMoney.Text = money + " $";
            }
            else
            {
                lblMoney.Text = dr.GetValue(0) + " $";
            }
            dr.Close();
        }//Shows money 
        void FillCbx()
        {
            SqlCommand commandFillCbb = new SqlCommand
            {
                Connection = connection,
                CommandText = "Select ItemName from tbl_Items"
            };

            SqlDataReader dr2 = commandFillCbb.ExecuteReader();
            while (dr2.Read())
            {
                cbxProduct.Items.Add(dr2["ItemName"].ToString());

            }
            dr2.Close();
        }//Shows Products in Combobox
        void FillFilterCBB()
        {
            SqlCommand commandFillCbb = new SqlCommand
            {
                Connection = connection,
                CommandText = "Select ItemName from tbl_Items"
            };

            SqlDataReader dr2 = commandFillCbb.ExecuteReader();
            while (dr2.Read())
            {
                cbbFilter.Items.Add(dr2["ItemName"].ToString());

            }
            dr2.Close();
        }//Shows Products in Combobox
        void FillDGVwithFilter()
        {
            SqlCommand commandShow = new SqlCommand
            {
                Connection = connection,
                CommandText = "Execute ShowMarketProductsFilter "+cbbFilter.SelectedIndex
            };
            SqlDataAdapter adapt = new SqlDataAdapter(commandShow);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dgvMarket.DataSource = dt;
        }
        private void FrmLoad()
        {
            cbbFilter.Items.Add("Show All");
            connection.Open();
            FillDGV();
            ShowMoney();
            FillCbx();
            FillFilterCBB();
            connection.Close();
        }

        void BuyProduct()
        {
            connection.Open();
            SqlCommand commandBuy = new SqlCommand
            {
                Connection = connection,
                CommandText="Execute BuyProduct "+us.UserID+","+(cbxProduct.SelectedIndex+1)+","+txtAmount.Text//This stored procedure was the hardest
            };
            commandBuy.ExecuteNonQuery();
            connection.Close();
        }
        private void BtnBuy_Click(object sender, EventArgs e)
        {
            BuyProduct();
            FrmLoad();
        }

        private void cbbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();

            if (cbbFilter.SelectedIndex==0)//Shows all products
            {
                FillDGV();
            }
            else//Shows selected product
            {
                FillDGVwithFilter();
            }
            connection.Close();
        }
    }
}
