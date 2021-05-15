using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazilimYapimiProject
{
    public partial class frmUser : Form
    {
        public frmUser(User user)
        {
            InitializeComponent();
            this.us = user;
        }

        readonly User us = new User();

        private void myPresenceToolStripMenuItem_Click(object sender, EventArgs e)//Show User Screen When MyPresence click
        { 
            this.ActiveMdiChild.Close();
            frmMyPresence form = new frmMyPresence(us);
            form.MdiParent = this;
            form.Show();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            frmMyPresence form = new frmMyPresence(us);
            form.MdiParent = this;
            form.Show();
        }

        private void marketToolStripMenuItem_Click(object sender, EventArgs e)//Show Market Screen When market click
        {
            this.ActiveMdiChild.Close();
            frmMarket form = new frmMarket(us);
            form.MdiParent = this;
            form.Show();
        }

        private void frmUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
