
namespace yazilimYapimiProject
{
    partial class frmMyPresence
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSell = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.BtnAddMoney = new System.Windows.Forms.Button();
            this.dgvMyProducts = new System.Windows.Forms.DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbAddProduct = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddProduct = new System.Windows.Forms.TextBox();
            this.BtnAddProduct = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTL = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "My Products";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAmount.Location = new System.Drawing.Point(649, 69);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(99, 30);
            this.txtAmount.TabIndex = 2;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPrice.Location = new System.Drawing.Point(649, 105);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(99, 30);
            this.txtPrice.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(557, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(581, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price:";
            // 
            // BtnSell
            // 
            this.BtnSell.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnSell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSell.Location = new System.Drawing.Point(649, 143);
            this.BtnSell.Name = "BtnSell";
            this.BtnSell.Size = new System.Drawing.Size(99, 70);
            this.BtnSell.TabIndex = 6;
            this.BtnSell.Text = "Sell";
            this.BtnSell.UseVisualStyleBackColor = false;
            this.BtnSell.Click += new System.EventHandler(this.BtnSell_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "My Wallet";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMoney.Location = new System.Drawing.Point(12, 343);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(45, 50);
            this.lblMoney.TabIndex = 8;
            this.lblMoney.Text = "₺";
            // 
            // txtMoney
            // 
            this.txtMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMoney.Location = new System.Drawing.Point(232, 343);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(100, 30);
            this.txtMoney.TabIndex = 9;
            // 
            // BtnAddMoney
            // 
            this.BtnAddMoney.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnAddMoney.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAddMoney.Location = new System.Drawing.Point(232, 376);
            this.BtnAddMoney.Name = "BtnAddMoney";
            this.BtnAddMoney.Size = new System.Drawing.Size(204, 41);
            this.BtnAddMoney.TabIndex = 10;
            this.BtnAddMoney.Text = "Add Money";
            this.BtnAddMoney.UseVisualStyleBackColor = false;
            this.BtnAddMoney.Click += new System.EventHandler(this.BtnAddMoney_Click);
            // 
            // dgvMyProducts
            // 
            this.dgvMyProducts.AllowUserToResizeColumns = false;
            this.dgvMyProducts.AllowUserToResizeRows = false;
            this.dgvMyProducts.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvMyProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.ItemID,
            this.ItemName,
            this.ItemAmount});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMyProducts.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMyProducts.Location = new System.Drawing.Point(17, 69);
            this.dgvMyProducts.MultiSelect = false;
            this.dgvMyProducts.Name = "dgvMyProducts";
            this.dgvMyProducts.RowHeadersVisible = false;
            this.dgvMyProducts.RowHeadersWidth = 51;
            this.dgvMyProducts.RowTemplate.Height = 24;
            this.dgvMyProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMyProducts.Size = new System.Drawing.Size(504, 226);
            this.dgvMyProducts.TabIndex = 13;
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "UserID";
            this.UserID.HeaderText = "User ID";
            this.UserID.MinimumWidth = 6;
            this.UserID.Name = "UserID";
            this.UserID.Visible = false;
            this.UserID.Width = 6;
            // 
            // ItemID
            // 
            this.ItemID.DataPropertyName = "ItemID";
            this.ItemID.HeaderText = "Product ID";
            this.ItemID.MinimumWidth = 6;
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            this.ItemID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemID.Width = 105;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "Name";
            this.ItemName.MinimumWidth = 6;
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemName.Width = 197;
            // 
            // ItemAmount
            // 
            this.ItemAmount.DataPropertyName = "ItemAmount";
            this.ItemAmount.HeaderText = "Amount";
            this.ItemAmount.MinimumWidth = 6;
            this.ItemAmount.Name = "ItemAmount";
            this.ItemAmount.ReadOnly = true;
            this.ItemAmount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemAmount.Width = 73;
            // 
            // cbbAddProduct
            // 
            this.cbbAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbbAddProduct.FormattingEnabled = true;
            this.cbbAddProduct.Location = new System.Drawing.Point(649, 272);
            this.cbbAddProduct.Name = "cbbAddProduct";
            this.cbbAddProduct.Size = new System.Drawing.Size(99, 30);
            this.cbbAddProduct.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(558, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Amount:";
            // 
            // txtAddProduct
            // 
            this.txtAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAddProduct.Location = new System.Drawing.Point(649, 308);
            this.txtAddProduct.Name = "txtAddProduct";
            this.txtAddProduct.Size = new System.Drawing.Size(99, 30);
            this.txtAddProduct.TabIndex = 15;
            // 
            // BtnAddProduct
            // 
            this.BtnAddProduct.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAddProduct.Location = new System.Drawing.Point(649, 347);
            this.BtnAddProduct.Name = "BtnAddProduct";
            this.BtnAddProduct.Size = new System.Drawing.Size(99, 70);
            this.BtnAddProduct.TabIndex = 17;
            this.BtnAddProduct.Text = "Add";
            this.BtnAddProduct.UseVisualStyleBackColor = false;
            this.BtnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(558, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Product:";
            // 
            // lblTL
            // 
            this.lblTL.AutoSize = true;
            this.lblTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTL.Location = new System.Drawing.Point(338, 344);
            this.lblTL.Name = "lblTL";
            this.lblTL.Size = new System.Drawing.Size(98, 29);
            this.lblTL.TabIndex = 19;
            this.lblTL.Text = "= 100 ₺";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Turkish Lira",
            "US Dollar",
            "Australian Dollar",
            "Danish Krone",
            "Euro",
            "Pound Sterling"});
            this.comboBox1.Location = new System.Drawing.Point(232, 305);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 30);
            this.comboBox1.TabIndex = 20;
            // 
            // frmMyPresence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 436);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblTL);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnAddProduct);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAddProduct);
            this.Controls.Add(this.cbbAddProduct);
            this.Controls.Add(this.dgvMyProducts);
            this.Controls.Add(this.BtnAddMoney);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnSell);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmMyPresence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMyPresence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSell;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Button BtnAddMoney;
        private System.Windows.Forms.DataGridView dgvMyProducts;
        private System.Windows.Forms.ComboBox cbbAddProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddProduct;
        private System.Windows.Forms.Button BtnAddProduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemAmount;
        private System.Windows.Forms.Label lblTL;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}