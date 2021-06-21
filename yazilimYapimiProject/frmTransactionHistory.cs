using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.IO;
using System.Data.SqlClient;

namespace yazilimYapimiProject
{
    public partial class frmTransactionHistory : Form
    {
        public frmTransactionHistory(User user)
        {
            us = user;
            InitializeComponent();
        }
        readonly User us = new User();
        readonly SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3PS3P83\\BERKCANSERVER;Initial Catalog=yazilimYapimi;Integrated Security=True");
        void fillDGV()//Listed by first date and last date.
        {
            connection.Open();
            SqlCommand fillDGV = new SqlCommand
            {
                Connection = connection,
                CommandText = "Execute ShowHistory "+us.UserID+",'"+dtpFirst.Value.Year+"-"+dtpFirst.Value.Month+"-"+dtpFirst.Value.Day+"','"+ dtpLast.Value.Year + "-" + dtpLast.Value.Month + "-" + dtpLast.Value.Day+"'"
            };
            SqlDataAdapter adapt = new SqlDataAdapter(fillDGV);
            System.Data.DataTable dt = new System.Data.DataTable();
            adapt.Fill(dt);
            dgvHistory.DataSource = dt;
            connection.Close();
        }
        void InsertToExcel()
        {
            sfdExcel.CreatePrompt = true;
            sfdExcel.Filter = "Excel Dosyası|.xls";//File type     -v File Name
            sfdExcel.FileName = "Report " + dtpFirst.Value.Day + "-" + dtpFirst.Value.Month + "-" + dtpFirst.Value.Year + " -- " + dtpLast.Value.Day + "-" + dtpLast.Value.Month + "-" + dtpLast.Value.Year;
            sfdExcel.RestoreDirectory = true;

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add();
            Microsoft.Office.Interop.Excel.Worksheet sheet = workbook.Sheets[1];
            sfdExcel.ShowDialog();
            for (int i = 1; i < dgvHistory.Columns.Count + 1; i++)
            {
                sheet.Cells[1, i] = dgvHistory.Columns[i - 1].HeaderText;
                sheet.Cells.ColumnWidth = 18;
            }
            for (int i = 0; i < dgvHistory.Rows.Count - 1; i++)
            { 
                for (int j = 0; j < dgvHistory.Columns.Count; j++)
                {
                    if (j == 3)
                        sheet.Cells.NumberFormat = "#,##.00_)";//Price format changed because excel writes 10x price
                    sheet.Cells[i + 2, j + 1] = dgvHistory.Rows[i].Cells[j].Value.ToString();
                }
            }
            workbook.SaveAs(sfdExcel.FileName);
            excel.Visible = false;
            excel.Quit();
        }
        private void frmTransactionHistory_Load(object sender, EventArgs e)
        {
            dtpLast.Value = DateTime.Now;
            fillDGV();
        }
        private void btnPrint_Click(object sender, EventArgs e)//Creates a report
        {
            InsertToExcel();
        }

        private void dtpFirst_ValueChanged(object sender, EventArgs e)//When first date changes
        {
            fillDGV();
        }

        private void dtpLast_ValueChanged(object sender, EventArgs e)//When last date changes
        {
            fillDGV();
        }
    }
}
