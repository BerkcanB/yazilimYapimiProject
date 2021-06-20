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

        void FillDGV(int type)
        {
            connection.Open();
            SqlCommand commandShow = new SqlCommand
            {
                Connection = connection,
                CommandText = "Execute ShowMarketProducts "+type 
            };
            SqlDataAdapter adapt = new SqlDataAdapter(commandShow);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dgvMarket.DataSource = dt;
            connection.Close();
        }//Fills the datagridview with market products
        void ShowMoney()
        {
            connection.Open();
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
                lblMoney.Text = money + " ₺";
            }
            else
            {
                lblMoney.Text = dr.GetValue(0) + " ₺";
            }
            dr.Close();
            connection.Close();
        }//Shows money 
        void FillCbx()
        {
            connection.Open();
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
            connection.Close();
        }//Shows Products in Combobox
        void FillFilterCBB()
        {
            connection.Open();
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
            connection.Close();
        }//Shows Products in Combobox
        void FillDGVwithFilter( int type)
        {
            connection.Open();
            SqlCommand commandShow = new SqlCommand
            {
                Connection = connection,
                CommandText = "Execute ShowMarketProductsFilter "+cbbFilter.SelectedIndex+","+type
            };
            SqlDataAdapter adapt = new SqlDataAdapter(commandShow);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dgvMarket.DataSource = dt;
            connection.Close();
        }//Fills the datagridview with market products, filters by cbbfilter
        private void FrmLoad()
        {
            cbbFilter.Items.Add("Show All");
            FillDGV(0);
            ShowMoney();
            FillCbx();
            FillFilterCBB();
        }

        void BuyProduct()
        {
            connection.Open();
            if(!CbxPrice.Checked)
            { 
                SqlCommand commandBuy = new SqlCommand
                {
                    Connection = connection,
                    CommandText="Execute BuyProduct "+us.UserID+","+(cbxProduct.SelectedIndex+1)+","+txtAmount.Text//This stored procedure was the hardest
                };
                commandBuy.ExecuteNonQuery();
            }
            else
            {
                SqlCommand commandBuyWithPrice = new SqlCommand
                {
                    Connection = connection,
                    CommandText = "Execute BuyProductWithPrice " + us.UserID + "," + (cbxProduct.SelectedIndex + 1) + "," + txtAmount.Text+","+Convert.ToDecimal(txtPrice.Text)//This stored procedure was the hardest
                };
                commandBuyWithPrice.ExecuteNonQuery();
            }
            connection.Close();
        }
        private void BtnBuy_Click(object sender, EventArgs e)
        {
            BuyProduct();
            if (cbbFilter.SelectedIndex == 0 || cbbFilter.SelectedIndex == -1)//Shows all products
            {
                FillDGV(0);
            }
            else//Shows selected product
            {
                FillDGVwithFilter(0);
            }
            ShowMoney();//Updates money
        }
        void FillDGVfilterChanged()
        {
            if ((cbbFilter.SelectedIndex == 0 || cbbFilter.SelectedIndex == -1) && (cbbmarketType.SelectedIndex == 0 || cbbmarketType.SelectedIndex == -1))//Shows Sales
            {
                FillDGV(0);
            }
            else if ((cbbFilter.SelectedIndex == 0 || cbbFilter.SelectedIndex == -1) && cbbmarketType.SelectedIndex == 1)
            {
                FillDGV(1);
            }
            else if ((cbbFilter.SelectedIndex != 0 || cbbFilter.SelectedIndex != -1) && (cbbmarketType.SelectedIndex == 0 || cbbmarketType.SelectedIndex == -1))//Shows selected product
            {
                FillDGVwithFilter(0);
            }
            else
            {
                FillDGVwithFilter(1);
            }
        }

        private void cbbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDGVfilterChanged();
        }

        private void CbxPrice_CheckedChanged(object sender, EventArgs e)
        {
            if(CbxPrice.Checked)
            {
                txtPrice.Enabled = true;
            }
            else
            {
                txtPrice.ResetText();
                txtPrice.Enabled = false;
            }
        }

        private void cbbmarketType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDGVfilterChanged();
        }
    }
}
