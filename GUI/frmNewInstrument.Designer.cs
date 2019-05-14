namespace GUI
{
    partial class frmNewInstrument
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
            this.groupBoxNewInstInstType = new System.Windows.Forms.GroupBox();
            this.comboBoxNewInstUnderlyingTicker = new System.Windows.Forms.ComboBox();
            this.lblNewInstUnderlyingTicker = new System.Windows.Forms.Label();
            this.textBoxNewInstBarrier = new System.Windows.Forms.TextBox();
            this.textBoxNewInstRebate = new System.Windows.Forms.TextBox();
            this.textBoxNewInstTenor = new System.Windows.Forms.TextBox();
            this.textBoxNewInstStrike = new System.Windows.Forms.TextBox();
            this.textBoxNewInstCompanyName = new System.Windows.Forms.TextBox();
            this.textBoxNewInstStockTicker = new System.Windows.Forms.TextBox();
            this.groupBoxNewInstCallOrPut = new System.Windows.Forms.GroupBox();
            this.radioButtonNewInstPut = new System.Windows.Forms.RadioButton();
            this.radioButtonNewInstCall = new System.Windows.Forms.RadioButton();
            this.lblNewInstBarrier = new System.Windows.Forms.Label();
            this.lblNewInstRebate = new System.Windows.Forms.Label();
            this.lblNewInstTenor = new System.Windows.Forms.Label();
            this.lblNewInstStrike = new System.Windows.Forms.Label();
            this.lblNewInstCompName = new System.Windows.Forms.Label();
            this.lblNewInstStockTicker = new System.Windows.Forms.Label();
            this.radioButtonNewInstDownAndOut = new System.Windows.Forms.RadioButton();
            this.radioButtonNewInstDownAndIn = new System.Windows.Forms.RadioButton();
            this.radioButtonUpAndOut = new System.Windows.Forms.RadioButton();
            this.radioButtonNewInstUpAndIn = new System.Windows.Forms.RadioButton();
            this.radioButtonNewInstDigital = new System.Windows.Forms.RadioButton();
            this.radioButtonNewInstRange = new System.Windows.Forms.RadioButton();
            this.radioButtonNewInstLookback = new System.Windows.Forms.RadioButton();
            this.radioButtonNewInstAsian = new System.Windows.Forms.RadioButton();
            this.radioButtonNewInstEuro = new System.Windows.Forms.RadioButton();
            this.radioButtonNewInstStock = new System.Windows.Forms.RadioButton();
            this.btnNewInstrumentAdd = new System.Windows.Forms.Button();
            this.groupBoxNewInstInstType.SuspendLayout();
            this.groupBoxNewInstCallOrPut.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxNewInstInstType
            // 
            this.groupBoxNewInstInstType.Controls.Add(this.comboBoxNewInstUnderlyingTicker);
            this.groupBoxNewInstInstType.Controls.Add(this.lblNewInstUnderlyingTicker);
            this.groupBoxNewInstInstType.Controls.Add(this.textBoxNewInstBarrier);
            this.groupBoxNewInstInstType.Controls.Add(this.textBoxNewInstRebate);
            this.groupBoxNewInstInstType.Controls.Add(this.textBoxNewInstTenor);
            this.groupBoxNewInstInstType.Controls.Add(this.textBoxNewInstStrike);
            this.groupBoxNewInstInstType.Controls.Add(this.textBoxNewInstCompanyName);
            this.groupBoxNewInstInstType.Controls.Add(this.textBoxNewInstStockTicker);
            this.groupBoxNewInstInstType.Controls.Add(this.groupBoxNewInstCallOrPut);
            this.groupBoxNewInstInstType.Controls.Add(this.lblNewInstBarrier);
            this.groupBoxNewInstInstType.Controls.Add(this.lblNewInstRebate);
            this.groupBoxNewInstInstType.Controls.Add(this.lblNewInstTenor);
            this.groupBoxNewInstInstType.Controls.Add(this.lblNewInstStrike);
            this.groupBoxNewInstInstType.Controls.Add(this.lblNewInstCompName);
            this.groupBoxNewInstInstType.Controls.Add(this.lblNewInstStockTicker);
            this.groupBoxNewInstInstType.Controls.Add(this.radioButtonNewInstDownAndOut);
            this.groupBoxNewInstInstType.Controls.Add(this.radioButtonNewInstDownAndIn);
            this.groupBoxNewInstInstType.Controls.Add(this.radioButtonUpAndOut);
            this.groupBoxNewInstInstType.Controls.Add(this.radioButtonNewInstUpAndIn);
            this.groupBoxNewInstInstType.Controls.Add(this.radioButtonNewInstDigital);
            this.groupBoxNewInstInstType.Controls.Add(this.radioButtonNewInstRange);
            this.groupBoxNewInstInstType.Controls.Add(this.radioButtonNewInstLookback);
            this.groupBoxNewInstInstType.Controls.Add(this.radioButtonNewInstAsian);
            this.groupBoxNewInstInstType.Controls.Add(this.radioButtonNewInstEuro);
            this.groupBoxNewInstInstType.Controls.Add(this.radioButtonNewInstStock);
            this.groupBoxNewInstInstType.Location = new System.Drawing.Point(12, 12);
            this.groupBoxNewInstInstType.Name = "groupBoxNewInstInstType";
            this.groupBoxNewInstInstType.Size = new System.Drawing.Size(413, 269);
            this.groupBoxNewInstInstType.TabIndex = 0;
            this.groupBoxNewInstInstType.TabStop = false;
            this.groupBoxNewInstInstType.Text = "Add New Instrument";
            this.groupBoxNewInstInstType.Enter += new System.EventHandler(this.GroupBoxNewInstInstType_Enter);
            // 
            // comboBoxNewInstUnderlyingTicker
            // 
            this.comboBoxNewInstUnderlyingTicker.Enabled = false;
            this.comboBoxNewInstUnderlyingTicker.FormattingEnabled = true;
            this.comboBoxNewInstUnderlyingTicker.Location = new System.Drawing.Point(280, 129);
            this.comboBoxNewInstUnderlyingTicker.Name = "comboBoxNewInstUnderlyingTicker";
            this.comboBoxNewInstUnderlyingTicker.Size = new System.Drawing.Size(105, 21);
            this.comboBoxNewInstUnderlyingTicker.TabIndex = 26;
            this.comboBoxNewInstUnderlyingTicker.SelectedIndexChanged += new System.EventHandler(this.ComboBoxNewInstUnderlyingTicker_SelectedIndexChanged);
            // 
            // lblNewInstUnderlyingTicker
            // 
            this.lblNewInstUnderlyingTicker.AutoSize = true;
            this.lblNewInstUnderlyingTicker.Location = new System.Drawing.Point(181, 132);
            this.lblNewInstUnderlyingTicker.Name = "lblNewInstUnderlyingTicker";
            this.lblNewInstUnderlyingTicker.Size = new System.Drawing.Size(93, 13);
            this.lblNewInstUnderlyingTicker.TabIndex = 25;
            this.lblNewInstUnderlyingTicker.Text = "Underlying Ticker:";
            this.lblNewInstUnderlyingTicker.Click += new System.EventHandler(this.LblNewInstUnderlyingTicker_Click);
            // 
            // textBoxNewInstBarrier
            // 
            this.textBoxNewInstBarrier.Enabled = false;
            this.textBoxNewInstBarrier.Location = new System.Drawing.Point(280, 233);
            this.textBoxNewInstBarrier.Name = "textBoxNewInstBarrier";
            this.textBoxNewInstBarrier.Size = new System.Drawing.Size(105, 20);
            this.textBoxNewInstBarrier.TabIndex = 24;
            this.textBoxNewInstBarrier.TextChanged += new System.EventHandler(this.TextBoxNewInstBarrier_TextChanged);
            // 
            // textBoxNewInstRebate
            // 
            this.textBoxNewInstRebate.Enabled = false;
            this.textBoxNewInstRebate.Location = new System.Drawing.Point(280, 207);
            this.textBoxNewInstRebate.Name = "textBoxNewInstRebate";
            this.textBoxNewInstRebate.Size = new System.Drawing.Size(105, 20);
            this.textBoxNewInstRebate.TabIndex = 23;
            this.textBoxNewInstRebate.TextChanged += new System.EventHandler(this.TextBoxNewInstRebate_TextChanged);
            // 
            // textBoxNewInstTenor
            // 
            this.textBoxNewInstTenor.Enabled = false;
            this.textBoxNewInstTenor.Location = new System.Drawing.Point(280, 182);
            this.textBoxNewInstTenor.Name = "textBoxNewInstTenor";
            this.textBoxNewInstTenor.Size = new System.Drawing.Size(105, 20);
            this.textBoxNewInstTenor.TabIndex = 22;
            this.textBoxNewInstTenor.TextChanged += new System.EventHandler(this.TextBoxNewInstTenor_TextChanged);
            // 
            // textBoxNewInstStrike
            // 
            this.textBoxNewInstStrike.Enabled = false;
            this.textBoxNewInstStrike.Location = new System.Drawing.Point(280, 156);
            this.textBoxNewInstStrike.Name = "textBoxNewInstStrike";
            this.textBoxNewInstStrike.Size = new System.Drawing.Size(105, 20);
            this.textBoxNewInstStrike.TabIndex = 21;
            this.textBoxNewInstStrike.TextChanged += new System.EventHandler(this.TextBoxNewInstStrike_TextChanged);
            // 
            // textBoxNewInstCompanyName
            // 
            this.textBoxNewInstCompanyName.Enabled = false;
            this.textBoxNewInstCompanyName.Location = new System.Drawing.Point(280, 103);
            this.textBoxNewInstCompanyName.Name = "textBoxNewInstCompanyName";
            this.textBoxNewInstCompanyName.Size = new System.Drawing.Size(105, 20);
            this.textBoxNewInstCompanyName.TabIndex = 19;
            this.textBoxNewInstCompanyName.TextChanged += new System.EventHandler(this.TextBoxNewInstCompanyName_TextChanged);
            // 
            // textBoxNewInstStockTicker
            // 
            this.textBoxNewInstStockTicker.Enabled = false;
            this.textBoxNewInstStockTicker.Location = new System.Drawing.Point(280, 77);
            this.textBoxNewInstStockTicker.Name = "textBoxNewInstStockTicker";
            this.textBoxNewInstStockTicker.Size = new System.Drawing.Size(105, 20);
            this.textBoxNewInstStockTicker.TabIndex = 18;
            this.textBoxNewInstStockTicker.TextChanged += new System.EventHandler(this.TextBoxNewInstStockTicker_TextChanged);
            // 
            // groupBoxNewInstCallOrPut
            // 
            this.groupBoxNewInstCallOrPut.Controls.Add(this.radioButtonNewInstPut);
            this.groupBoxNewInstCallOrPut.Controls.Add(this.radioButtonNewInstCall);
            this.groupBoxNewInstCallOrPut.Enabled = false;
            this.groupBoxNewInstCallOrPut.Location = new System.Drawing.Point(280, 29);
            this.groupBoxNewInstCallOrPut.Name = "groupBoxNewInstCallOrPut";
            this.groupBoxNewInstCallOrPut.Size = new System.Drawing.Size(105, 40);
            this.groupBoxNewInstCallOrPut.TabIndex = 17;
            this.groupBoxNewInstCallOrPut.TabStop = false;
            this.groupBoxNewInstCallOrPut.Text = "Call or Put";
            this.groupBoxNewInstCallOrPut.Enter += new System.EventHandler(this.GroupBoxNewInstCallOrPut_Enter);
            // 
            // radioButtonNewInstPut
            // 
            this.radioButtonNewInstPut.AutoSize = true;
            this.radioButtonNewInstPut.Enabled = false;
            this.radioButtonNewInstPut.Location = new System.Drawing.Point(54, 19);
            this.radioButtonNewInstPut.Name = "radioButtonNewInstPut";
            this.radioButtonNewInstPut.Size = new System.Drawing.Size(41, 17);
            this.radioButtonNewInstPut.TabIndex = 1;
            this.radioButtonNewInstPut.Text = "Put";
            this.radioButtonNewInstPut.UseVisualStyleBackColor = true;
            this.radioButtonNewInstPut.CheckedChanged += new System.EventHandler(this.RadioButtonNewInstPut_CheckedChanged);
            // 
            // radioButtonNewInstCall
            // 
            this.radioButtonNewInstCall.AutoSize = true;
            this.radioButtonNewInstCall.Checked = true;
            this.radioButtonNewInstCall.Enabled = false;
            this.radioButtonNewInstCall.Location = new System.Drawing.Point(6, 19);
            this.radioButtonNewInstCall.Name = "radioButtonNewInstCall";
            this.radioButtonNewInstCall.Size = new System.Drawing.Size(42, 17);
            this.radioButtonNewInstCall.TabIndex = 0;
            this.radioButtonNewInstCall.TabStop = true;
            this.radioButtonNewInstCall.Text = "Call";
            this.radioButtonNewInstCall.UseVisualStyleBackColor = true;
            this.radioButtonNewInstCall.CheckedChanged += new System.EventHandler(this.RadioButtonNewInstCall_CheckedChanged);
            // 
            // lblNewInstBarrier
            // 
            this.lblNewInstBarrier.AutoSize = true;
            this.lblNewInstBarrier.Location = new System.Drawing.Point(234, 236);
            this.lblNewInstBarrier.Name = "lblNewInstBarrier";
            this.lblNewInstBarrier.Size = new System.Drawing.Size(40, 13);
            this.lblNewInstBarrier.TabIndex = 16;
            this.lblNewInstBarrier.Text = "Barrier:";
            this.lblNewInstBarrier.Click += new System.EventHandler(this.LblNewInstBarrier_Click);
            // 
            // lblNewInstRebate
            // 
            this.lblNewInstRebate.AutoSize = true;
            this.lblNewInstRebate.Location = new System.Drawing.Point(229, 210);
            this.lblNewInstRebate.Name = "lblNewInstRebate";
            this.lblNewInstRebate.Size = new System.Drawing.Size(45, 13);
            this.lblNewInstRebate.TabIndex = 15;
            this.lblNewInstRebate.Text = "Rebate:";
            this.lblNewInstRebate.Click += new System.EventHandler(this.LblNewInstRebate_Click);
            // 
            // lblNewInstTenor
            // 
            this.lblNewInstTenor.AutoSize = true;
            this.lblNewInstTenor.Location = new System.Drawing.Point(236, 185);
            this.lblNewInstTenor.Name = "lblNewInstTenor";
            this.lblNewInstTenor.Size = new System.Drawing.Size(38, 13);
            this.lblNewInstTenor.TabIndex = 14;
            this.lblNewInstTenor.Text = "Tenor:";
            this.lblNewInstTenor.Click += new System.EventHandler(this.LblNewInstTenor_Click);
            // 
            // lblNewInstStrike
            // 
            this.lblNewInstStrike.AutoSize = true;
            this.lblNewInstStrike.Location = new System.Drawing.Point(237, 159);
            this.lblNewInstStrike.Name = "lblNewInstStrike";
            this.lblNewInstStrike.Size = new System.Drawing.Size(37, 13);
            this.lblNewInstStrike.TabIndex = 13;
            this.lblNewInstStrike.Text = "Strike:";
            this.lblNewInstStrike.Click += new System.EventHandler(this.LblNewInstStrike_Click);
            // 
            // lblNewInstCompName
            // 
            this.lblNewInstCompName.AutoSize = true;
            this.lblNewInstCompName.Location = new System.Drawing.Point(189, 106);
            this.lblNewInstCompName.Name = "lblNewInstCompName";
            this.lblNewInstCompName.Size = new System.Drawing.Size(85, 13);
            this.lblNewInstCompName.TabIndex = 12;
            this.lblNewInstCompName.Text = "Company Name:";
            this.lblNewInstCompName.Click += new System.EventHandler(this.LblNewInstCompName_Click);
            // 
            // lblNewInstStockTicker
            // 
            this.lblNewInstStockTicker.AutoSize = true;
            this.lblNewInstStockTicker.Location = new System.Drawing.Point(203, 80);
            this.lblNewInstStockTicker.Name = "lblNewInstStockTicker";
            this.lblNewInstStockTicker.Size = new System.Drawing.Size(71, 13);
            this.lblNewInstStockTicker.TabIndex = 10;
            this.lblNewInstStockTicker.Text = "Stock Ticker:";
            this.lblNewInstStockTicker.Click += new System.EventHandler(this.LblNewInstStockTicker_Click);
            // 
            // radioButtonNewInstDownAndOut
            // 
            this.radioButtonNewInstDownAndOut.AutoSize = true;
            this.radioButtonNewInstDownAndOut.Location = new System.Drawing.Point(6, 236);
            this.radioButtonNewInstDownAndOut.Name = "radioButtonNewInstDownAndOut";
            this.radioButtonNewInstDownAndOut.Size = new System.Drawing.Size(167, 17);
            this.radioButtonNewInstDownAndOut.TabIndex = 9;
            this.radioButtonNewInstDownAndOut.TabStop = true;
            this.radioButtonNewInstDownAndOut.Text = "Barrier Option (Down and Out)";
            this.radioButtonNewInstDownAndOut.UseVisualStyleBackColor = true;
            this.radioButtonNewInstDownAndOut.CheckedChanged += new System.EventHandler(this.RadioButtonNewInstDownAndOut_CheckedChanged);
            // 
            // radioButtonNewInstDownAndIn
            // 
            this.radioButtonNewInstDownAndIn.AutoSize = true;
            this.radioButtonNewInstDownAndIn.Location = new System.Drawing.Point(6, 213);
            this.radioButtonNewInstDownAndIn.Name = "radioButtonNewInstDownAndIn";
            this.radioButtonNewInstDownAndIn.Size = new System.Drawing.Size(159, 17);
            this.radioButtonNewInstDownAndIn.TabIndex = 8;
            this.radioButtonNewInstDownAndIn.TabStop = true;
            this.radioButtonNewInstDownAndIn.Text = "Barrier Option (Down and In)";
            this.radioButtonNewInstDownAndIn.UseVisualStyleBackColor = true;
            this.radioButtonNewInstDownAndIn.CheckedChanged += new System.EventHandler(this.RadioButtonNewInstDownAndIn_CheckedChanged);
            // 
            // radioButtonUpAndOut
            // 
            this.radioButtonUpAndOut.AutoSize = true;
            this.radioButtonUpAndOut.Location = new System.Drawing.Point(6, 190);
            this.radioButtonUpAndOut.Name = "radioButtonUpAndOut";
            this.radioButtonUpAndOut.Size = new System.Drawing.Size(153, 17);
            this.radioButtonUpAndOut.TabIndex = 7;
            this.radioButtonUpAndOut.TabStop = true;
            this.radioButtonUpAndOut.Text = "Barrier Option (Up and Out)";
            this.radioButtonUpAndOut.UseVisualStyleBackColor = true;
            this.radioButtonUpAndOut.CheckedChanged += new System.EventHandler(this.RadioButtonUpAndOut_CheckedChanged);
            // 
            // radioButtonNewInstUpAndIn
            // 
            this.radioButtonNewInstUpAndIn.AutoSize = true;
            this.radioButtonNewInstUpAndIn.Location = new System.Drawing.Point(6, 167);
            this.radioButtonNewInstUpAndIn.Name = "radioButtonNewInstUpAndIn";
            this.radioButtonNewInstUpAndIn.Size = new System.Drawing.Size(145, 17);
            this.radioButtonNewInstUpAndIn.TabIndex = 6;
            this.radioButtonNewInstUpAndIn.TabStop = true;
            this.radioButtonNewInstUpAndIn.Text = "Barrier Option (Up and In)";
            this.radioButtonNewInstUpAndIn.UseVisualStyleBackColor = true;
            this.radioButtonNewInstUpAndIn.CheckedChanged += new System.EventHandler(this.RadioButton7_CheckedChanged);
            // 
            // radioButtonNewInstDigital
            // 
            this.radioButtonNewInstDigital.AutoSize = true;
            this.radioButtonNewInstDigital.Location = new System.Drawing.Point(6, 144);
            this.radioButtonNewInstDigital.Name = "radioButtonNewInstDigital";
            this.radioButtonNewInstDigital.Size = new System.Drawing.Size(88, 17);
            this.radioButtonNewInstDigital.TabIndex = 5;
            this.radioButtonNewInstDigital.TabStop = true;
            this.radioButtonNewInstDigital.Text = "Digital Option";
            this.radioButtonNewInstDigital.UseVisualStyleBackColor = true;
            this.radioButtonNewInstDigital.CheckedChanged += new System.EventHandler(this.RadioButtonNewInstDigital_CheckedChanged);
            // 
            // radioButtonNewInstRange
            // 
            this.radioButtonNewInstRange.AutoSize = true;
            this.radioButtonNewInstRange.Location = new System.Drawing.Point(6, 121);
            this.radioButtonNewInstRange.Name = "radioButtonNewInstRange";
            this.radioButtonNewInstRange.Size = new System.Drawing.Size(91, 17);
            this.radioButtonNewInstRange.TabIndex = 4;
            this.radioButtonNewInstRange.TabStop = true;
            this.radioButtonNewInstRange.Text = "Range Option";
            this.radioButtonNewInstRange.UseVisualStyleBackColor = true;
            this.radioButtonNewInstRange.CheckedChanged += new System.EventHandler(this.RadioButtonNewInstRange_CheckedChanged);
            // 
            // radioButtonNewInstLookback
            // 
            this.radioButtonNewInstLookback.AutoSize = true;
            this.radioButtonNewInstLookback.Location = new System.Drawing.Point(6, 98);
            this.radioButtonNewInstLookback.Name = "radioButtonNewInstLookback";
            this.radioButtonNewInstLookback.Size = new System.Drawing.Size(107, 17);
            this.radioButtonNewInstLookback.TabIndex = 3;
            this.radioButtonNewInstLookback.TabStop = true;
            this.radioButtonNewInstLookback.Text = "Lookback Option";
            this.radioButtonNewInstLookback.UseVisualStyleBackColor = true;
            this.radioButtonNewInstLookback.CheckedChanged += new System.EventHandler(this.RadioButtonNewInstLookback_CheckedChanged);
            // 
            // radioButtonNewInstAsian
            // 
            this.radioButtonNewInstAsian.AutoSize = true;
            this.radioButtonNewInstAsian.Location = new System.Drawing.Point(6, 75);
            this.radioButtonNewInstAsian.Name = "radioButtonNewInstAsian";
            this.radioButtonNewInstAsian.Size = new System.Drawing.Size(85, 17);
            this.radioButtonNewInstAsian.TabIndex = 2;
            this.radioButtonNewInstAsian.TabStop = true;
            this.radioButtonNewInstAsian.Text = "Asian Option";
            this.radioButtonNewInstAsian.UseVisualStyleBackColor = true;
            this.radioButtonNewInstAsian.CheckedChanged += new System.EventHandler(this.RadioButtonNewInstAsian_CheckedChanged);
            // 
            // radioButtonNewInstEuro
            // 
            this.radioButtonNewInstEuro.AutoSize = true;
            this.radioButtonNewInstEuro.Location = new System.Drawing.Point(6, 52);
            this.radioButtonNewInstEuro.Name = "radioButtonNewInstEuro";
            this.radioButtonNewInstEuro.Size = new System.Drawing.Size(81, 17);
            this.radioButtonNewInstEuro.TabIndex = 1;
            this.radioButtonNewInstEuro.TabStop = true;
            this.radioButtonNewInstEuro.Text = "Euro Option";
            this.radioButtonNewInstEuro.UseVisualStyleBackColor = true;
            this.radioButtonNewInstEuro.CheckedChanged += new System.EventHandler(this.RadioButtonNewInstEuro_CheckedChanged);
            // 
            // radioButtonNewInstStock
            // 
            this.radioButtonNewInstStock.AutoSize = true;
            this.radioButtonNewInstStock.Location = new System.Drawing.Point(6, 29);
            this.radioButtonNewInstStock.Name = "radioButtonNewInstStock";
            this.radioButtonNewInstStock.Size = new System.Drawing.Size(53, 17);
            this.radioButtonNewInstStock.TabIndex = 0;
            this.radioButtonNewInstStock.TabStop = true;
            this.radioButtonNewInstStock.Text = "Stock";
            this.radioButtonNewInstStock.UseVisualStyleBackColor = true;
            this.radioButtonNewInstStock.CheckedChanged += new System.EventHandler(this.RadioButtonNewInstStock_CheckedChanged);
            // 
            // btnNewInstrumentAdd
            // 
            this.btnNewInstrumentAdd.Location = new System.Drawing.Point(181, 287);
            this.btnNewInstrumentAdd.Name = "btnNewInstrumentAdd";
            this.btnNewInstrumentAdd.Size = new System.Drawing.Size(75, 23);
            this.btnNewInstrumentAdd.TabIndex = 1;
            this.btnNewInstrumentAdd.Text = "Add";
            this.btnNewInstrumentAdd.UseVisualStyleBackColor = true;
            this.btnNewInstrumentAdd.Click += new System.EventHandler(this.BtnNewInstrumentAdd_Click);
            // 
            // frmNewInstrument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 319);
            this.Controls.Add(this.btnNewInstrumentAdd);
            this.Controls.Add(this.groupBoxNewInstInstType);
            this.Name = "frmNewInstrument";
            this.Text = "frmNewInstrument";
            this.Load += new System.EventHandler(this.FrmNewInstrument_Load);
            this.groupBoxNewInstInstType.ResumeLayout(false);
            this.groupBoxNewInstInstType.PerformLayout();
            this.groupBoxNewInstCallOrPut.ResumeLayout(false);
            this.groupBoxNewInstCallOrPut.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxNewInstInstType;
        private System.Windows.Forms.RadioButton radioButtonNewInstDownAndOut;
        private System.Windows.Forms.RadioButton radioButtonNewInstDownAndIn;
        private System.Windows.Forms.RadioButton radioButtonUpAndOut;
        private System.Windows.Forms.RadioButton radioButtonNewInstUpAndIn;
        private System.Windows.Forms.RadioButton radioButtonNewInstDigital;
        private System.Windows.Forms.RadioButton radioButtonNewInstRange;
        private System.Windows.Forms.RadioButton radioButtonNewInstLookback;
        private System.Windows.Forms.RadioButton radioButtonNewInstAsian;
        private System.Windows.Forms.RadioButton radioButtonNewInstEuro;
        private System.Windows.Forms.RadioButton radioButtonNewInstStock;
        private System.Windows.Forms.GroupBox groupBoxNewInstCallOrPut;
        private System.Windows.Forms.RadioButton radioButtonNewInstPut;
        private System.Windows.Forms.RadioButton radioButtonNewInstCall;
        private System.Windows.Forms.Label lblNewInstBarrier;
        private System.Windows.Forms.Label lblNewInstRebate;
        private System.Windows.Forms.Label lblNewInstTenor;
        private System.Windows.Forms.Label lblNewInstStrike;
        private System.Windows.Forms.Label lblNewInstCompName;
        private System.Windows.Forms.Label lblNewInstStockTicker;
        private System.Windows.Forms.TextBox textBoxNewInstBarrier;
        private System.Windows.Forms.TextBox textBoxNewInstRebate;
        private System.Windows.Forms.TextBox textBoxNewInstTenor;
        private System.Windows.Forms.TextBox textBoxNewInstStrike;
        private System.Windows.Forms.TextBox textBoxNewInstCompanyName;
        private System.Windows.Forms.TextBox textBoxNewInstStockTicker;
        private System.Windows.Forms.Label lblNewInstUnderlyingTicker;
        private System.Windows.Forms.ComboBox comboBoxNewInstUnderlyingTicker;
        private System.Windows.Forms.Button btnNewInstrumentAdd;
    }
}