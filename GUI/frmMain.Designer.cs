namespace GUI
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instrumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interestRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historicalStockPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMainVol = new System.Windows.Forms.Label();
            this.textBoxMainVol = new System.Windows.Forms.TextBox();
            this.btnMainCalc = new System.Windows.Forms.Button();
            this.btnMainRefresh = new System.Windows.Forms.Button();
            this.listViewMainBook = new System.Windows.Forms.ListView();
            this.columnHeadertotalpl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeadertotaldelta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeadertotalgamma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeadertotalvega = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeadertotaltheta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeadertotalrho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewMainTradeView = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDirection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderInstrument = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTradeprice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMarketPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderpl2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDelta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGamma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderVega = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTheta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1381, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instrumentToolStripMenuItem,
            this.tradeToolStripMenuItem,
            this.interestRateToolStripMenuItem,
            this.historicalStockPriceToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.fileToolStripMenuItem.Text = "New...";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.FileToolStripMenuItem_Click);
            // 
            // instrumentToolStripMenuItem
            // 
            this.instrumentToolStripMenuItem.Name = "instrumentToolStripMenuItem";
            this.instrumentToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.instrumentToolStripMenuItem.Text = "Instrument";
            this.instrumentToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // tradeToolStripMenuItem
            // 
            this.tradeToolStripMenuItem.Name = "tradeToolStripMenuItem";
            this.tradeToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.tradeToolStripMenuItem.Text = "Trade";
            this.tradeToolStripMenuItem.Click += new System.EventHandler(this.TradeToolStripMenuItem_Click);
            // 
            // interestRateToolStripMenuItem
            // 
            this.interestRateToolStripMenuItem.Name = "interestRateToolStripMenuItem";
            this.interestRateToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.interestRateToolStripMenuItem.Text = "Interest rate";
            this.interestRateToolStripMenuItem.Click += new System.EventHandler(this.InterestRateToolStripMenuItem_Click);
            // 
            // historicalStockPriceToolStripMenuItem
            // 
            this.historicalStockPriceToolStripMenuItem.Name = "historicalStockPriceToolStripMenuItem";
            this.historicalStockPriceToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.historicalStockPriceToolStripMenuItem.Text = "Historical Stock Price";
            this.historicalStockPriceToolStripMenuItem.Click += new System.EventHandler(this.HistoricalStockPriceToolStripMenuItem_Click);
            // 
            // lblMainVol
            // 
            this.lblMainVol.AutoSize = true;
            this.lblMainVol.Location = new System.Drawing.Point(12, 57);
            this.lblMainVol.Name = "lblMainVol";
            this.lblMainVol.Size = new System.Drawing.Size(135, 13);
            this.lblMainVol.TabIndex = 1;
            this.lblMainVol.Text = "Volatility (Enter as decimal):";
            this.lblMainVol.Click += new System.EventHandler(this.LblMainVol_Click);
            // 
            // textBoxMainVol
            // 
            this.textBoxMainVol.Location = new System.Drawing.Point(153, 54);
            this.textBoxMainVol.Name = "textBoxMainVol";
            this.textBoxMainVol.Size = new System.Drawing.Size(100, 20);
            this.textBoxMainVol.TabIndex = 2;
            this.textBoxMainVol.TextChanged += new System.EventHandler(this.TextBoxMainVol_TextChanged);
            // 
            // btnMainCalc
            // 
            this.btnMainCalc.Location = new System.Drawing.Point(714, 390);
            this.btnMainCalc.Name = "btnMainCalc";
            this.btnMainCalc.Size = new System.Drawing.Size(155, 41);
            this.btnMainCalc.TabIndex = 3;
            this.btnMainCalc.Text = "Calculate Book PnL";
            this.btnMainCalc.UseVisualStyleBackColor = true;
            this.btnMainCalc.Click += new System.EventHandler(this.BtnMainCalc_Click);
            // 
            // btnMainRefresh
            // 
            this.btnMainRefresh.Location = new System.Drawing.Point(553, 390);
            this.btnMainRefresh.Name = "btnMainRefresh";
            this.btnMainRefresh.Size = new System.Drawing.Size(155, 41);
            this.btnMainRefresh.TabIndex = 4;
            this.btnMainRefresh.Text = "Refresh Data";
            this.btnMainRefresh.UseVisualStyleBackColor = true;
            this.btnMainRefresh.Click += new System.EventHandler(this.BtnMainRefresh_Click);
            // 
            // listViewMainBook
            // 
            this.listViewMainBook.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeadertotalpl,
            this.columnHeadertotaldelta,
            this.columnHeadertotalgamma,
            this.columnHeadertotalvega,
            this.columnHeadertotaltheta,
            this.columnHeadertotalrho});
            this.listViewMainBook.FullRowSelect = true;
            this.listViewMainBook.GridLines = true;
            this.listViewMainBook.Location = new System.Drawing.Point(15, 90);
            this.listViewMainBook.Name = "listViewMainBook";
            this.listViewMainBook.Size = new System.Drawing.Size(804, 45);
            this.listViewMainBook.TabIndex = 6;
            this.listViewMainBook.UseCompatibleStateImageBehavior = false;
            this.listViewMainBook.View = System.Windows.Forms.View.Details;
            this.listViewMainBook.SelectedIndexChanged += new System.EventHandler(this.ListViewMainBook_SelectedIndexChanged);
            // 
            // columnHeadertotalpl
            // 
            this.columnHeadertotalpl.Text = "TotalP&L";
            this.columnHeadertotalpl.Width = 126;
            // 
            // columnHeadertotaldelta
            // 
            this.columnHeadertotaldelta.Text = "Total Delta";
            this.columnHeadertotaldelta.Width = 120;
            // 
            // columnHeadertotalgamma
            // 
            this.columnHeadertotalgamma.Text = "Total Gamma";
            this.columnHeadertotalgamma.Width = 127;
            // 
            // columnHeadertotalvega
            // 
            this.columnHeadertotalvega.Text = "Total Vega";
            this.columnHeadertotalvega.Width = 140;
            // 
            // columnHeadertotaltheta
            // 
            this.columnHeadertotaltheta.Text = "Total Theta";
            this.columnHeadertotaltheta.Width = 143;
            // 
            // columnHeadertotalrho
            // 
            this.columnHeadertotalrho.Text = "Total Rho";
            this.columnHeadertotalrho.Width = 142;
            // 
            // listViewMainTradeView
            // 
            this.listViewMainTradeView.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listViewMainTradeView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderDirection,
            this.columnHeaderQuantity,
            this.columnHeaderInstrument,
            this.columnHeaderTradeprice,
            this.columnHeaderMarketPrice,
            this.columnHeaderpl2,
            this.columnHeaderDelta,
            this.columnHeaderGamma,
            this.columnHeaderVega,
            this.columnHeaderTheta,
            this.columnHeaderRho});
            this.listViewMainTradeView.FullRowSelect = true;
            this.listViewMainTradeView.GridLines = true;
            this.listViewMainTradeView.Location = new System.Drawing.Point(15, 164);
            this.listViewMainTradeView.Name = "listViewMainTradeView";
            this.listViewMainTradeView.Size = new System.Drawing.Size(1342, 195);
            this.listViewMainTradeView.TabIndex = 7;
            this.listViewMainTradeView.UseCompatibleStateImageBehavior = false;
            this.listViewMainTradeView.View = System.Windows.Forms.View.Details;
            this.listViewMainTradeView.SelectedIndexChanged += new System.EventHandler(this.ListViewMainTradeView_SelectedIndexChanged);
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "ID";
            this.columnHeaderId.Width = 51;
            // 
            // columnHeaderDirection
            // 
            this.columnHeaderDirection.Text = "BuyOrSell";
            this.columnHeaderDirection.Width = 67;
            // 
            // columnHeaderQuantity
            // 
            this.columnHeaderQuantity.Text = "Quantity";
            this.columnHeaderQuantity.Width = 72;
            // 
            // columnHeaderInstrument
            // 
            this.columnHeaderInstrument.Text = "InstrumentName";
            this.columnHeaderInstrument.Width = 104;
            // 
            // columnHeaderTradeprice
            // 
            this.columnHeaderTradeprice.Text = "PriceTradedAt";
            this.columnHeaderTradeprice.Width = 96;
            // 
            // columnHeaderMarketPrice
            // 
            this.columnHeaderMarketPrice.Text = "MarkToMarket";
            this.columnHeaderMarketPrice.Width = 97;
            // 
            // columnHeaderpl2
            // 
            this.columnHeaderpl2.Text = "PnL";
            this.columnHeaderpl2.Width = 91;
            // 
            // columnHeaderDelta
            // 
            this.columnHeaderDelta.Text = "Delta";
            this.columnHeaderDelta.Width = 80;
            // 
            // columnHeaderGamma
            // 
            this.columnHeaderGamma.Text = "Gamma";
            this.columnHeaderGamma.Width = 77;
            // 
            // columnHeaderVega
            // 
            this.columnHeaderVega.Text = "Vega";
            this.columnHeaderVega.Width = 66;
            // 
            // columnHeaderTheta
            // 
            this.columnHeaderTheta.Text = "Theta";
            // 
            // columnHeaderRho
            // 
            this.columnHeaderRho.Text = "Rho";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Trade View:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 458);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewMainTradeView);
            this.Controls.Add(this.listViewMainBook);
            this.Controls.Add(this.btnMainRefresh);
            this.Controls.Add(this.btnMainCalc);
            this.Controls.Add(this.textBoxMainVol);
            this.Controls.Add(this.lblMainVol);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instrumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tradeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interestRateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historicalStockPriceToolStripMenuItem;
        private System.Windows.Forms.Label lblMainVol;
        private System.Windows.Forms.TextBox textBoxMainVol;
        private System.Windows.Forms.Button btnMainCalc;
        private System.Windows.Forms.Button btnMainRefresh;
        private System.Windows.Forms.ListView listViewMainBook;
        private System.Windows.Forms.ColumnHeader columnHeadertotalpl;
        private System.Windows.Forms.ColumnHeader columnHeadertotaldelta;
        private System.Windows.Forms.ColumnHeader columnHeadertotalgamma;
        private System.Windows.Forms.ColumnHeader columnHeadertotalvega;
        private System.Windows.Forms.ColumnHeader columnHeadertotaltheta;
        private System.Windows.Forms.ColumnHeader columnHeadertotalrho;
        private System.Windows.Forms.ListView listViewMainTradeView;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderDirection;
        private System.Windows.Forms.ColumnHeader columnHeaderQuantity;
        private System.Windows.Forms.ColumnHeader columnHeaderInstrument;
        private System.Windows.Forms.ColumnHeader columnHeaderTradeprice;
        private System.Windows.Forms.ColumnHeader columnHeaderMarketPrice;
        private System.Windows.Forms.ColumnHeader columnHeaderpl2;
        private System.Windows.Forms.ColumnHeader columnHeaderDelta;
        private System.Windows.Forms.ColumnHeader columnHeaderGamma;
        private System.Windows.Forms.ColumnHeader columnHeaderVega;
        private System.Windows.Forms.ColumnHeader columnHeaderTheta;
        private System.Windows.Forms.ColumnHeader columnHeaderRho;
        private System.Windows.Forms.Label label1;
    }
}

