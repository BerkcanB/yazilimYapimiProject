using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace yazilimYapimiProject
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        readonly SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3PS3P83\\BERKCANSERVER;Initial Catalog=yazilimYapimi;Integrated Security=True");
        
        SqlCommand Command(int i)
        {
            SqlCommand command2 = new SqlCommand// User ID to be unique.
            {
                Connection = connection,
                CommandText = "SELECT UserID FROM tbl_Users WHERE UserID = " + txtID.Text
            };

            SqlCommand command3 = new SqlCommand// User Email to be unique.
            {
                Connection = connection,
                CommandText = "SELECT E_Mail from tbl_Users WHERE E_Mail= '" + txtEmail.Text + "'"
            };

            SqlCommand command = new SqlCommand
            {
                Connection = connection,
                CommandText = "Execute InsertUserInformations @UserID=" + Convert.ToInt32(txtID.Text) + ", @UserPassword='" + txtPassword.Text +
                            "',@UserName='" + txtName.Text + "',@UserSurname='" + txtSurname.Text + "',@User_TC_Number='" + txtTC.Text +
                            "',@Tel_Number='" + txtTelNumber.Text + "',@Address='" + txtAddress.Text +
                            "',@E_Mail='" + txtEmail.Text + "'"
            };//for insert to server

            if (i==0)
            {
                return command;
            }
            else if (i==2)
            {
                return command2;
            }
            else if(i==3)
            {
                return command3;
            }
            return command;
        }
        void ControllerAndRegister()
        {
            if (txtName.Text == "" && txtSurname.Text == "" && txtTC.Text == ""
                && txtTelNumber.Text == "" && txtEmail.Text == "" && txtAddress.Text == ""
                && txtID.Text == "" && txtPassword.Text == "" && txtPassword2.Text == "")
            {
                MessageBox.Show("Please fill in all the blanks.", "Error!");
            }
            else if (!txtID.Text.All(char.IsDigit))//It checks if the username is a numeric.
            {
                MessageBox.Show("User ID must be numeric!", "Error!");
            }
            else
            {
                SqlDataReader dataReader = Command(2).ExecuteReader();
                dataReader.Read();
                if (dataReader.HasRows)//comparing the userID with the database
                {
                    MessageBox.Show("User ID already exist.", "Error!");
                }
                else
                {
                    dataReader.Close();
                    SqlDataReader dataReader2 = Command(3).ExecuteReader();
                    dataReader2.Read();
                    if (dataReader2.HasRows)//comparing the Email with the database
                    {
                        MessageBox.Show("E_Mail already exist.", "Error!");
                    }
                    else if (txtPassword.Text != txtPassword2.Text)
                    {
                        MessageBox.Show("The Second Password must be the same as the first password!", "Error!");
                    }
                    else
                    {
                        dataReader2.Close();
                        Command(0).ExecuteNonQuery();
                        Command(2).ExecuteNonQuery();
                        MessageBox.Show("You successfully registered!", "Success");
                        connection.Close();
                        this.Close();
                    }
                }
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            connection.Close();
            connection.Open();
            ControllerAndRegister();//Controls labels and Register User
        }
        private void frmRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Close();
        }
    }
}
