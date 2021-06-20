
namespace yazilimYapimiProject
{
    partial class frmAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.cbxAdmin = new System.Windows.Forms.ComboBox();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.RtnRefuse = new System.Windows.Forms.Button();
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxAdmin
            // 
            this.cbxAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxAdmin.FormattingEnabled = true;
            this.cbxAdmin.Items.AddRange(new object[] {
            "Product Adding Requests",
            "Deposit Requests"});
            this.cbxAdmin.Location = new System.Drawing.Point(12, 8);
            this.cbxAdmin.Name = "cbxAdmin";
            this.cbxAdmin.Size = new System.Drawing.Size(334, 37);
            this.cbxAdmin.TabIndex = 3;
            this.cbxAdmin.SelectedIndexChanged += new System.EventHandler(this.cbxAdmin_SelectedIndexChanged);
            // 
            // BtnAccept
            // 
            this.BtnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAccept.Location = new System.Drawing.Point(360, 344);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(196, 64);
            this.BtnAccept.TabIndex = 4;
            this.BtnAccept.Text = "Accept";
            this.BtnAccept.UseVisualStyleBackColor = true;
            this.BtnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // RtnRefuse
            // 
            this.RtnRefuse.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RtnRefuse.Location = new System.Drawing.Point(595, 344);
            this.RtnRefuse.Name = "RtnRefuse";
            this.RtnRefuse.Size = new System.Drawing.Size(193, 64);
            this.RtnRefuse.TabIndex = 5;
            this.RtnRefuse.Text = "Refuse";
            this.RtnRefuse.UseVisualStyleBackColor = true;
            this.RtnRefuse.Click += new System.EventHandler(this.RtnRefuse_Click);
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.AllowUserToResizeColumns = false;
            this.dgvAdmin.AllowUserToResizeRows = false;
            this.dgvAdmin.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Location = new System.Drawing.Point(12, 60);
            this.dgvAdmin.MultiSelect = false;
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.ReadOnly = true;
            this.dgvAdmin.RowHeadersVisible = false;
            this.dgvAdmin.RowHeadersWidth = 51;
            this.dgvAdmin.RowTemplate.Height = 24;
            this.dgvAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdmin.Size = new System.Drawing.Size(776, 278);
            this.dgvAdmin.TabIndex = 6;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdmin.Location = new System.Drawing.Point(518, 15);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(74, 25);
            this.lblAdmin.TabIndex = 7;
            this.lblAdmin.Text = "Admin:";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMoney.Location = new System.Drawing.Point(22, 375);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(55, 60);
            this.lblMoney.TabIndex = 12;
            this.lblMoney.Text = "₺";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "My Wallet";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.dgvAdmin);
            this.Controls.Add(this.RtnRefuse);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.cbxAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator Screen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdmin_FormClosed);
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxAdmin;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.Button RtnRefuse;
        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label label4;
    }
}