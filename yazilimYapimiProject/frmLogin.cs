using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace yazilimYapimiProject
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        //Connection
        readonly SqlConnection connection =new SqlConnection("Data Source=DESKTOP-3PS3P83\\BERKCANSERVER;Initial Catalog=yazilimYapimi;Integrated Security=True");
        

        private void llbRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//Shows Register Screen
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.ShowDialog();
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
                connection.Open();
                SqlCommand command = new SqlCommand
                {
                Connection = connection,
                CommandText = "Execute LoginScreen @UserID="+Convert.ToInt32(txtID.Text)+ ", @UserPassword=" + txtPassword.Text//Easily retrieve data from database using UserID
                };
            SqlDataReader dr = command.ExecuteReader();
            dr.Read();

            if(!dr.HasRows)//Checking database using UserID
            {
                MessageBox.Show("User ID or Password incorrect.", "Error");
            }
            else
            {
                User user= new User//This takes user informations from Database using UserID
                {
                    UserID = Convert.ToInt32(dr["UserID"]),
                    Name = dr["UserName"].ToString(),
                    SurName = dr["UserSurname"].ToString(),
                    TCNumber = dr["User_TC_Number"].ToString(),
                    TelNumber = dr["Tel_Number"].ToString(),
                    Address = dr["Address"].ToString(),
                    Email = dr["E_Mail"].ToString(),
                    UserTypeID = Convert.ToInt32(dr["UserTypeID"])
                };
                this.Hide();
                if(user.UserTypeID==2)
                {
                    frmUser frmUser = new frmUser(user);
                    frmUser.Show();
                }
                else if(user.UserTypeID==1)
                {
                    frmAdmin frmAdmin = new frmAdmin(user);
                    frmAdmin.Show();
                }
            }
            connection.Close();
        }
    }
}