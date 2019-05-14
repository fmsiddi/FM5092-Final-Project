namespace GUI
{
    partial class frmNewInterestRate
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
            this.lblNewRateTenor = new System.Windows.Forms.Label();
            this.comboBoxNewRateTenor = new System.Windows.Forms.ComboBox();
            this.lblNewRateRate = new System.Windows.Forms.Label();
            this.textBoxNewRateRate = new System.Windows.Forms.TextBox();
            this.btnNewRateAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNewRateTenor
            // 
            this.lblNewRateTenor.AutoSize = true;
            this.lblNewRateTenor.Location = new System.Drawing.Point(91, 18);
            this.lblNewRateTenor.Name = "lblNewRateTenor";
            this.lblNewRateTenor.Size = new System.Drawing.Size(92, 13);
            this.lblNewRateTenor.TabIndex = 0;
            this.lblNewRateTenor.Text = "Tenor (in months):";
            this.lblNewRateTenor.Click += new System.EventHandler(this.LblNewRateTenor_Click);
            // 
            // comboBoxNewRateTenor
            // 
            this.comboBoxNewRateTenor.FormattingEnabled = true;
            this.comboBoxNewRateTenor.Items.AddRange(new object[] {
            "1",
            "3",
            "6",
            "12",
            "24",
            "36",
            "60",
            "84",
            "120",
            "240",
            "360"});
            this.comboBoxNewRateTenor.Location = new System.Drawing.Point(189, 15);
            this.comboBoxNewRateTenor.Name = "comboBoxNewRateTenor";
            this.comboBoxNewRateTenor.Size = new System.Drawing.Size(100, 21);
            this.comboBoxNewRateTenor.TabIndex = 1;
            this.comboBoxNewRateTenor.SelectedIndexChanged += new System.EventHandler(this.ComboBoxNewRateTenor_SelectedIndexChanged);
            // 
            // lblNewRateRate
            // 
            this.lblNewRateRate.AutoSize = true;
            this.lblNewRateRate.Location = new System.Drawing.Point(7, 45);
            this.lblNewRateRate.Name = "lblNewRateRate";
            this.lblNewRateRate.Size = new System.Drawing.Size(176, 13);
            this.lblNewRateRate.TabIndex = 2;
            this.lblNewRateRate.Text = "Interest Rate (in percentage points):";
            this.lblNewRateRate.Click += new System.EventHandler(this.LblNewRateRate_Click);
            // 
            // textBoxNewRateRate
            // 
            this.textBoxNewRateRate.Location = new System.Drawing.Point(189, 42);
            this.textBoxNewRateRate.Name = "textBoxNewRateRate";
            this.textBoxNewRateRate.Size = new System.Drawing.Size(100, 20);
            this.textBoxNewRateRate.TabIndex = 3;
            this.textBoxNewRateRate.TextChanged += new System.EventHandler(this.TextBoxNewRateRate_TextChanged);
            // 
            // btnNewRateAdd
            // 
            this.btnNewRateAdd.Location = new System.Drawing.Point(122, 78);
            this.btnNewRateAdd.Name = "btnNewRateAdd";
            this.btnNewRateAdd.Size = new System.Drawing.Size(75, 23);
            this.btnNewRateAdd.TabIndex = 4;
            this.btnNewRateAdd.Text = "Add";
            this.btnNewRateAdd.UseVisualStyleBackColor = true;
            this.btnNewRateAdd.Click += new System.EventHandler(this.BtnNewRateAdd_Click);
            // 
            // frmNewInterestRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 115);
            this.Controls.Add(this.btnNewRateAdd);
            this.Controls.Add(this.textBoxNewRateRate);
            this.Controls.Add(this.lblNewRateRate);
            this.Controls.Add(this.comboBoxNewRateTenor);
            this.Controls.Add(this.lblNewRateTenor);
            this.Name = "frmNewInterestRate";
            this.Text = "frmNewInterestRate";
            this.Load += new System.EventHandler(this.FrmNewInterestRate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewRateTenor;
        private System.Windows.Forms.ComboBox comboBoxNewRateTenor;
        private System.Windows.Forms.Label lblNewRateRate;
        private System.Windows.Forms.TextBox textBoxNewRateRate;
        private System.Windows.Forms.Button btnNewRateAdd;
    }
}