namespace GUI
{
    partial class frmNewHistoricalPrice
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
            this.lblNewPriceTicker = new System.Windows.Forms.Label();
            this.comboBoxNewPriceTicker = new System.Windows.Forms.ComboBox();
            this.lblNewPriceDate = new System.Windows.Forms.Label();
            this.lblNewPricePrice = new System.Windows.Forms.Label();
            this.textBoxNewPricePrice = new System.Windows.Forms.TextBox();
            this.dateTimePickerNewPriceDate = new System.Windows.Forms.DateTimePicker();
            this.btnNewPriceAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNewPriceTicker
            // 
            this.lblNewPriceTicker.AutoSize = true;
            this.lblNewPriceTicker.Location = new System.Drawing.Point(39, 30);
            this.lblNewPriceTicker.Name = "lblNewPriceTicker";
            this.lblNewPriceTicker.Size = new System.Drawing.Size(71, 13);
            this.lblNewPriceTicker.TabIndex = 0;
            this.lblNewPriceTicker.Text = "Stock Ticker:";
            this.lblNewPriceTicker.Click += new System.EventHandler(this.LblNewPriceTicker_Click);
            // 
            // comboBoxNewPriceTicker
            // 
            this.comboBoxNewPriceTicker.FormattingEnabled = true;
            this.comboBoxNewPriceTicker.Location = new System.Drawing.Point(116, 27);
            this.comboBoxNewPriceTicker.Name = "comboBoxNewPriceTicker";
            this.comboBoxNewPriceTicker.Size = new System.Drawing.Size(100, 21);
            this.comboBoxNewPriceTicker.TabIndex = 1;
            this.comboBoxNewPriceTicker.SelectedIndexChanged += new System.EventHandler(this.ComboBoxNewPriceTicker_SelectedIndexChanged);
            // 
            // lblNewPriceDate
            // 
            this.lblNewPriceDate.AutoSize = true;
            this.lblNewPriceDate.Location = new System.Drawing.Point(50, 57);
            this.lblNewPriceDate.Name = "lblNewPriceDate";
            this.lblNewPriceDate.Size = new System.Drawing.Size(60, 13);
            this.lblNewPriceDate.TabIndex = 2;
            this.lblNewPriceDate.Text = "Price Date:";
            this.lblNewPriceDate.Click += new System.EventHandler(this.LblNewPriceDate_Click);
            // 
            // lblNewPricePrice
            // 
            this.lblNewPricePrice.AutoSize = true;
            this.lblNewPricePrice.Location = new System.Drawing.Point(39, 83);
            this.lblNewPricePrice.Name = "lblNewPricePrice";
            this.lblNewPricePrice.Size = new System.Drawing.Size(71, 13);
            this.lblNewPricePrice.TabIndex = 4;
            this.lblNewPricePrice.Text = "Closing Price:";
            this.lblNewPricePrice.Click += new System.EventHandler(this.LblNewPricePrice_Click);
            // 
            // textBoxNewPricePrice
            // 
            this.textBoxNewPricePrice.Location = new System.Drawing.Point(116, 80);
            this.textBoxNewPricePrice.Name = "textBoxNewPricePrice";
            this.textBoxNewPricePrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxNewPricePrice.TabIndex = 5;
            this.textBoxNewPricePrice.TextChanged += new System.EventHandler(this.TextBoxNewPricePrice_TextChanged);
            // 
            // dateTimePickerNewPriceDate
            // 
            this.dateTimePickerNewPriceDate.Location = new System.Drawing.Point(116, 54);
            this.dateTimePickerNewPriceDate.Name = "dateTimePickerNewPriceDate";
            this.dateTimePickerNewPriceDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerNewPriceDate.TabIndex = 6;
            this.dateTimePickerNewPriceDate.ValueChanged += new System.EventHandler(this.DateTimePickerNewPriceDate_ValueChanged);
            // 
            // btnNewPriceAdd
            // 
            this.btnNewPriceAdd.Location = new System.Drawing.Point(132, 119);
            this.btnNewPriceAdd.Name = "btnNewPriceAdd";
            this.btnNewPriceAdd.Size = new System.Drawing.Size(75, 23);
            this.btnNewPriceAdd.TabIndex = 7;
            this.btnNewPriceAdd.Text = "Add";
            this.btnNewPriceAdd.UseVisualStyleBackColor = true;
            this.btnNewPriceAdd.Click += new System.EventHandler(this.BtnNewPriceAdd_Click);
            // 
            // frmNewHistoricalPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 158);
            this.Controls.Add(this.btnNewPriceAdd);
            this.Controls.Add(this.dateTimePickerNewPriceDate);
            this.Controls.Add(this.textBoxNewPricePrice);
            this.Controls.Add(this.lblNewPricePrice);
            this.Controls.Add(this.lblNewPriceDate);
            this.Controls.Add(this.comboBoxNewPriceTicker);
            this.Controls.Add(this.lblNewPriceTicker);
            this.Name = "frmNewHistoricalPrice";
            this.Text = "frmNewHistoricalPrice";
            this.Load += new System.EventHandler(this.FrmNewHistoricalPrice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewPriceTicker;
        private System.Windows.Forms.ComboBox comboBoxNewPriceTicker;
        private System.Windows.Forms.Label lblNewPriceDate;
        private System.Windows.Forms.Label lblNewPricePrice;
        private System.Windows.Forms.TextBox textBoxNewPricePrice;
        private System.Windows.Forms.DateTimePicker dateTimePickerNewPriceDate;
        private System.Windows.Forms.Button btnNewPriceAdd;
    }
}