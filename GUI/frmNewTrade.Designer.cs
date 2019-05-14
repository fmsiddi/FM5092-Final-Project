namespace GUI
{
    partial class frmNewTrade
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
            this.groupBoxNewTradeDirection = new System.Windows.Forms.GroupBox();
            this.radioButtonNewTradeSell = new System.Windows.Forms.RadioButton();
            this.radioButtonNewTradeBuy = new System.Windows.Forms.RadioButton();
            this.lblNewTradeQuantity = new System.Windows.Forms.Label();
            this.textBoxNewTradeQuantity = new System.Windows.Forms.TextBox();
            this.dateTimePickerNewTrade = new System.Windows.Forms.DateTimePicker();
            this.lblNewTradeTradeDate = new System.Windows.Forms.Label();
            this.textBoxNewTradePrice = new System.Windows.Forms.TextBox();
            this.lblNewTradePrice = new System.Windows.Forms.Label();
            this.lblNewTradeInstrument = new System.Windows.Forms.Label();
            this.comboBoxNewTradeInstrument = new System.Windows.Forms.ComboBox();
            this.btnNewTradeAdd = new System.Windows.Forms.Button();
            this.groupBoxNewTradeDirection.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxNewTradeDirection
            // 
            this.groupBoxNewTradeDirection.Controls.Add(this.radioButtonNewTradeSell);
            this.groupBoxNewTradeDirection.Controls.Add(this.radioButtonNewTradeBuy);
            this.groupBoxNewTradeDirection.Location = new System.Drawing.Point(150, 7);
            this.groupBoxNewTradeDirection.Name = "groupBoxNewTradeDirection";
            this.groupBoxNewTradeDirection.Size = new System.Drawing.Size(100, 40);
            this.groupBoxNewTradeDirection.TabIndex = 0;
            this.groupBoxNewTradeDirection.TabStop = false;
            this.groupBoxNewTradeDirection.Text = "Direction";
            this.groupBoxNewTradeDirection.Enter += new System.EventHandler(this.GroupBoxNewTradeDirection_Enter);
            // 
            // radioButtonNewTradeSell
            // 
            this.radioButtonNewTradeSell.AutoSize = true;
            this.radioButtonNewTradeSell.Location = new System.Drawing.Point(52, 16);
            this.radioButtonNewTradeSell.Name = "radioButtonNewTradeSell";
            this.radioButtonNewTradeSell.Size = new System.Drawing.Size(42, 17);
            this.radioButtonNewTradeSell.TabIndex = 1;
            this.radioButtonNewTradeSell.TabStop = true;
            this.radioButtonNewTradeSell.Text = "Sell";
            this.radioButtonNewTradeSell.UseVisualStyleBackColor = true;
            this.radioButtonNewTradeSell.CheckedChanged += new System.EventHandler(this.RadioButtonNewTradeSell_CheckedChanged);
            // 
            // radioButtonNewTradeBuy
            // 
            this.radioButtonNewTradeBuy.AutoSize = true;
            this.radioButtonNewTradeBuy.Checked = true;
            this.radioButtonNewTradeBuy.Location = new System.Drawing.Point(3, 16);
            this.radioButtonNewTradeBuy.Name = "radioButtonNewTradeBuy";
            this.radioButtonNewTradeBuy.Size = new System.Drawing.Size(43, 17);
            this.radioButtonNewTradeBuy.TabIndex = 0;
            this.radioButtonNewTradeBuy.TabStop = true;
            this.radioButtonNewTradeBuy.Text = "Buy";
            this.radioButtonNewTradeBuy.UseVisualStyleBackColor = true;
            this.radioButtonNewTradeBuy.CheckedChanged += new System.EventHandler(this.RadioButtonNewTradeBuy_CheckedChanged);
            // 
            // lblNewTradeQuantity
            // 
            this.lblNewTradeQuantity.AutoSize = true;
            this.lblNewTradeQuantity.Location = new System.Drawing.Point(95, 109);
            this.lblNewTradeQuantity.Name = "lblNewTradeQuantity";
            this.lblNewTradeQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblNewTradeQuantity.TabIndex = 2;
            this.lblNewTradeQuantity.Text = "Quantity:";
            this.lblNewTradeQuantity.Click += new System.EventHandler(this.LblNewTradeQuantity_Click);
            // 
            // textBoxNewTradeQuantity
            // 
            this.textBoxNewTradeQuantity.Location = new System.Drawing.Point(150, 106);
            this.textBoxNewTradeQuantity.Name = "textBoxNewTradeQuantity";
            this.textBoxNewTradeQuantity.Size = new System.Drawing.Size(100, 20);
            this.textBoxNewTradeQuantity.TabIndex = 3;
            this.textBoxNewTradeQuantity.TextChanged += new System.EventHandler(this.TextBoxNewTradeQuantity_TextChanged);
            // 
            // dateTimePickerNewTrade
            // 
            this.dateTimePickerNewTrade.Location = new System.Drawing.Point(150, 53);
            this.dateTimePickerNewTrade.Name = "dateTimePickerNewTrade";
            this.dateTimePickerNewTrade.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerNewTrade.TabIndex = 4;
            this.dateTimePickerNewTrade.ValueChanged += new System.EventHandler(this.DateTimePickerNewTrade_ValueChanged);
            // 
            // lblNewTradeTradeDate
            // 
            this.lblNewTradeTradeDate.AutoSize = true;
            this.lblNewTradeTradeDate.Location = new System.Drawing.Point(80, 59);
            this.lblNewTradeTradeDate.Name = "lblNewTradeTradeDate";
            this.lblNewTradeTradeDate.Size = new System.Drawing.Size(64, 13);
            this.lblNewTradeTradeDate.TabIndex = 5;
            this.lblNewTradeTradeDate.Text = "Trade Date:";
            this.lblNewTradeTradeDate.Click += new System.EventHandler(this.LblNewTradeTradeDate_Click);
            // 
            // textBoxNewTradePrice
            // 
            this.textBoxNewTradePrice.Enabled = false;
            this.textBoxNewTradePrice.Location = new System.Drawing.Point(150, 132);
            this.textBoxNewTradePrice.Name = "textBoxNewTradePrice";
            this.textBoxNewTradePrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxNewTradePrice.TabIndex = 6;
            this.textBoxNewTradePrice.TextChanged += new System.EventHandler(this.TextBoxNewTradePrice_TextChanged);
            // 
            // lblNewTradePrice
            // 
            this.lblNewTradePrice.AutoSize = true;
            this.lblNewTradePrice.Location = new System.Drawing.Point(13, 135);
            this.lblNewTradePrice.Name = "lblNewTradePrice";
            this.lblNewTradePrice.Size = new System.Drawing.Size(131, 13);
            this.lblNewTradePrice.TabIndex = 7;
            this.lblNewTradePrice.Text = "What You Paid for Option:";
            this.lblNewTradePrice.Click += new System.EventHandler(this.LblNewTradePrice_Click);
            // 
            // lblNewTradeInstrument
            // 
            this.lblNewTradeInstrument.AutoSize = true;
            this.lblNewTradeInstrument.Location = new System.Drawing.Point(85, 82);
            this.lblNewTradeInstrument.Name = "lblNewTradeInstrument";
            this.lblNewTradeInstrument.Size = new System.Drawing.Size(59, 13);
            this.lblNewTradeInstrument.TabIndex = 8;
            this.lblNewTradeInstrument.Text = "Instrument:";
            this.lblNewTradeInstrument.Click += new System.EventHandler(this.LblNewTradeInstrument_Click);
            // 
            // comboBoxNewTradeInstrument
            // 
            this.comboBoxNewTradeInstrument.FormattingEnabled = true;
            this.comboBoxNewTradeInstrument.Location = new System.Drawing.Point(150, 79);
            this.comboBoxNewTradeInstrument.Name = "comboBoxNewTradeInstrument";
            this.comboBoxNewTradeInstrument.Size = new System.Drawing.Size(445, 21);
            this.comboBoxNewTradeInstrument.TabIndex = 9;
            this.comboBoxNewTradeInstrument.SelectedIndexChanged += new System.EventHandler(this.ComboBoxNewTradeInstrument_SelectedIndexChanged);
            // 
            // btnNewTradeAdd
            // 
            this.btnNewTradeAdd.Location = new System.Drawing.Point(331, 130);
            this.btnNewTradeAdd.Name = "btnNewTradeAdd";
            this.btnNewTradeAdd.Size = new System.Drawing.Size(75, 23);
            this.btnNewTradeAdd.TabIndex = 10;
            this.btnNewTradeAdd.Text = "Add";
            this.btnNewTradeAdd.UseVisualStyleBackColor = true;
            this.btnNewTradeAdd.Click += new System.EventHandler(this.BtnNewTradeAdd_Click);
            // 
            // frmNewTrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 177);
            this.Controls.Add(this.btnNewTradeAdd);
            this.Controls.Add(this.comboBoxNewTradeInstrument);
            this.Controls.Add(this.lblNewTradeInstrument);
            this.Controls.Add(this.lblNewTradePrice);
            this.Controls.Add(this.textBoxNewTradePrice);
            this.Controls.Add(this.lblNewTradeTradeDate);
            this.Controls.Add(this.dateTimePickerNewTrade);
            this.Controls.Add(this.textBoxNewTradeQuantity);
            this.Controls.Add(this.lblNewTradeQuantity);
            this.Controls.Add(this.groupBoxNewTradeDirection);
            this.Name = "frmNewTrade";
            this.Text = "frmNewTrade";
            this.Load += new System.EventHandler(this.FrmNewTrade_Load);
            this.groupBoxNewTradeDirection.ResumeLayout(false);
            this.groupBoxNewTradeDirection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxNewTradeDirection;
        private System.Windows.Forms.RadioButton radioButtonNewTradeSell;
        private System.Windows.Forms.RadioButton radioButtonNewTradeBuy;
        private System.Windows.Forms.Label lblNewTradeQuantity;
        private System.Windows.Forms.TextBox textBoxNewTradeQuantity;
        private System.Windows.Forms.DateTimePicker dateTimePickerNewTrade;
        private System.Windows.Forms.Label lblNewTradeTradeDate;
        private System.Windows.Forms.TextBox textBoxNewTradePrice;
        private System.Windows.Forms.Label lblNewTradePrice;
        private System.Windows.Forms.Label lblNewTradeInstrument;
        private System.Windows.Forms.ComboBox comboBoxNewTradeInstrument;
        private System.Windows.Forms.Button btnNewTradeAdd;
    }
}