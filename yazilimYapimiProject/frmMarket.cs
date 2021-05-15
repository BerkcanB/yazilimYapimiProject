using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        User us = new User();
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3PS3P83\\BERKCANSERVER;Initial Catalog=yazilimYapimi;Integrated Security=True");

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
        }
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
        }
        private void FrmLoad()
        {
            connection.Open();
            FillDGV();//Fill datagridview from tbl_Market
            ShowMoney();//Show Money from tbl_Moneys
            FillCbx();//Fill combobox from tbl_Items
            connection.Close();
        }

        void BuyProduct()
        {
            connection.Open();
            SqlCommand commandBuy = new SqlCommand
            {
                Connection = connection,
                CommandText="Execute BuyProduct "+us.UserID+","+(cbxProduct.SelectedIndex+1)+","+txtAmount.Text
            };
            commandBuy.ExecuteNonQuery();
            connection.Close();
        }
        private void BtnBuy_Click(object sender, EventArgs e)
        {
            BuyProduct();
            FrmLoad();
        }
    }
}
