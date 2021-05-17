using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace yazilimYapimiProject
{
    public partial class frmAdmin : Form
    {
        public frmAdmin(User user)
        {
            us = user;
            InitializeComponent();
        }

        readonly User us = new User();
        readonly SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3PS3P83\\BERKCANSERVER;Initial Catalog=yazilimYapimi;Integrated Security=True");

        void ShowAdminInfo()
        {
            lblAdmin.Text = "Admin: " + us.Name + " " + us.SurName; 
        }

        void ShowInfo(string commandText)
        {
            connection.Open();
            SqlCommand commandShow = new SqlCommand
            {
                Connection = connection,
                CommandText = commandText
            };
            SqlDataAdapter adapt = new SqlDataAdapter(commandShow);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dgvAdmin.DataSource = dt;
            connection.Close();
        }

        private void cbxAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if     (cbxAdmin.SelectedIndex == 0)
            {
                ShowInfo("Execute ShowProductRequests");
            }
            else if(cbxAdmin.SelectedIndex == 1)
            {
                ShowInfo("Execute ShowMoneyRequests");
            }
        }

        void AcceptOrRefuseProductRequest(int type, int accept)//type=1 ->Product Add Request
        {                                                      //type=0 ->Money Add Request
            int requestID = Convert.ToInt32(dgvAdmin.SelectedCells[0].Value.ToString());//it takes Selected Index's RequestID
            connection.Open();                                 //accept=1 ->Accept Button
            SqlCommand commandRequest = new SqlCommand          //accept=0 ->Refuse Button
            {
                Connection = connection,
                CommandText = "Execute AcceptOrRefuseRequest "+ requestID +", "+type+", "+accept
            };
            commandRequest.ExecuteNonQuery();
            connection.Close();
        }

        private void BtnAccept_Click(object sender, EventArgs e)//type will be used for "ShowProductRequests" sql stored procedure
        {                                                       //type define request type. 1 is 
            int type;
            if(cbxAdmin.SelectedIndex == 0)//If Selected Index is Product Request, type will be 1
            {
                type = 1;
                AcceptOrRefuseProductRequest(type, 1);//2. parameter is 1 because here is accept button click event
                ShowInfo("Execute ShowProductRequests");//Refresh the datagridview
            }
            else if(cbxAdmin.SelectedIndex == 1)//If Selected Index is Money Request, type will be 0
            {
                type = 0;
                AcceptOrRefuseProductRequest(type, 1);//2. parameter is 1 because here is accept button click event
                ShowInfo("Execute ShowMoneyRequests");//Refresh the datagridview
            }
        }

        private void RtnRefuse_Click(object sender, EventArgs e)
        {
            int type;
            if (cbxAdmin.SelectedIndex == 0)//If Selected Index is Product Request, type will be 1
            {
                type = 1;
                AcceptOrRefuseProductRequest(type, 0);//2. parameter is 1 because here is refuse button click event
                ShowInfo("Execute ShowProductRequests");//Refresh the datagridview
            }
            else if (cbxAdmin.SelectedIndex == 1)//If Selected Index is Money Request, type will be 0
            {
                type = 0;
                AcceptOrRefuseProductRequest(type, 0);//2. parameter is 1 because here is refuse button click event
                ShowInfo("Execute ShowMoneyRequests");//Refresh the datagridview
            }
        }

        private void frmAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            ShowAdminInfo();
            cbxAdmin.SelectedIndex = 0;
        }
    }
}
