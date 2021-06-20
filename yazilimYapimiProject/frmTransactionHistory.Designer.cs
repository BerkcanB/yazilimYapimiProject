
namespace yazilimYapimiProject
{
    partial class frmTransactionHistory
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
            this.components = new System.ComponentModel.Container();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFirst = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpLast = new System.Windows.Forms.DateTimePicker();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblQuestionMark = new System.Windows.Forms.Label();
            this.sfdExcel = new System.Windows.Forms.SaveFileDialog();
            this.ttpQuestionMark = new System.Windows.Forms.ToolTip(this.components);
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarketType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistory
            // 
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.MarketType,
            this.Product,
            this.Price,
            this.Amount});
            this.dgvHistory.Location = new System.Drawing.Point(12, 96);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHistory.RowHeadersVisible = false;
            this.dgvHistory.RowHeadersWidth = 51;
            this.dgvHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvHistory.RowTemplate.Height = 24;
            this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistory.Size = new System.Drawing.Size(754, 263);
            this.dgvHistory.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(337, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date Range";
            // 
            // dtpFirst
            // 
            this.dtpFirst.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpFirst.Location = new System.Drawing.Point(61, 43);
            this.dtpFirst.Name = "dtpFirst";
            this.dtpFirst.Size = new System.Drawing.Size(279, 28);
            this.dtpFirst.TabIndex = 2;
            this.dtpFirst.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtpFirst.ValueChanged += new System.EventHandler(this.dtpFirst_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(380, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "-";
            // 
            // dtpLast
            // 
            this.dtpLast.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpLast.Location = new System.Drawing.Point(437, 43);
            this.dtpLast.Name = "dtpLast";
            this.dtpLast.Size = new System.Drawing.Size(279, 28);
            this.dtpLast.TabIndex = 4;
            this.dtpLast.Value = new System.DateTime(2021, 6, 20, 1, 25, 46, 0);
            this.dtpLast.ValueChanged += new System.EventHandler(this.dtpLast_ValueChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrint.Location = new System.Drawing.Point(551, 365);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(215, 59);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print To Excel";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblQuestionMark
            // 
            this.lblQuestionMark.AutoSize = true;
            this.lblQuestionMark.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuestionMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuestionMark.Location = new System.Drawing.Point(495, 379);
            this.lblQuestionMark.Name = "lblQuestionMark";
            this.lblQuestionMark.Size = new System.Drawing.Size(30, 31);
            this.lblQuestionMark.TabIndex = 6;
            this.lblQuestionMark.Text = "?";
            this.ttpQuestionMark.SetToolTip(this.lblQuestionMark, "An excel file is created for \r\nthe desired date and path.\r\n");
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // MarketType
            // 
            this.MarketType.DataPropertyName = "Type";
            this.MarketType.HeaderText = "Sale/Purchase";
            this.MarketType.MinimumWidth = 6;
            this.MarketType.Name = "MarketType";
            this.MarketType.ReadOnly = true;
            // 
            // Product
            // 
            this.Product.DataPropertyName = "ItemName";
            this.Product.HeaderText = "Product";
            this.Product.MinimumWidth = 6;
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // frmTransactionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 436);
            this.Controls.Add(this.lblQuestionMark);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dtpLast);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFirst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTransactionHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTransactionHistory";
            this.Load += new System.EventHandler(this.frmTransactionHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFirst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpLast;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblQuestionMark;
        private System.Windows.Forms.SaveFileDialog sfdExcel;
        private System.Windows.Forms.ToolTip ttpQuestionMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarketType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}