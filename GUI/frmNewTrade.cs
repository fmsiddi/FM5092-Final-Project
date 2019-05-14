using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB;

namespace GUI
{
    public partial class frmNewTrade : Form
    {
        public frmNewTrade()
        {
            InitializeComponent();
        }

        EntityModelContainer EMC = new EntityModelContainer();
        DB.Trade t = new DB.Trade();

        private void FrmNewTrade_Load(object sender, EventArgs e)
        {
            comboBoxNewTradeInstrument.DataSource = (from i in EMC.Instruments select i.InstrumentTicker).Distinct().ToList();
        }

        private void GroupBoxNewTradeDirection_Enter(object sender, EventArgs e)
        {

        }

        private void RadioButtonNewTradeBuy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButtonNewTradeSell_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LblNewTradeTradeDate_Click(object sender, EventArgs e)
        {

        }

        private void LblNewTradeInstrument_Click(object sender, EventArgs e)
        {

        }

        private void LblNewTradeQuantity_Click(object sender, EventArgs e)
        {

        }

        private void LblNewTradePrice_Click(object sender, EventArgs e)
        {

        }

        private void DateTimePickerNewTrade_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxNewTradeInstrument_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxNewTradePrice.Enabled = comboBoxNewTradeInstrument.Text.Contains("_OPT_");
        }

        private void TextBoxNewTradeQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxNewTradePrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnNewTradeAdd_Click(object sender, EventArgs e)
        {
            string buyOrSell;
            double tradePrice;
            int quantity;

            if (radioButtonNewTradeBuy.Checked)
            {
                buyOrSell = "BUY";
            }
            else
            {
                buyOrSell = "SELL";
            }

            try
            {
                quantity = Int32.Parse(textBoxNewTradeQuantity.Text);
            }
            catch (Exception xc)
            {
                MessageBox.Show(xc.Message);
            }
            quantity = Convert.ToInt32(textBoxNewTradeQuantity.Text);

            if (comboBoxNewTradeInstrument.Text.Contains("_OPT_"))
            {
                try
                {
                    tradePrice = Double.Parse(textBoxNewTradePrice.Text);
                }
                catch (Exception xc)
                {
                    MessageBox.Show(xc.Message);
                }
                tradePrice = Convert.ToDouble(textBoxNewTradePrice.Text);
            }
            else
            {
                tradePrice = (from p in EMC.Prices where p.Date == dateTimePickerNewTrade.Value.Date && p.UnderlyingTicker == comboBoxNewTradeInstrument.Text select p.ClosingPrice).FirstOrDefault();
            }

            t.BuyOrSell = buyOrSell;
            t.Quantity = quantity;
            t.PriceTradedAt = tradePrice;
            t.TradeDate = dateTimePickerNewTrade.Value.Date;
            t.InstrumentName = comboBoxNewTradeInstrument.Text;

            EMC.Trades.Add(t);
            EMC.SaveChanges();

            MessageBox.Show("Action Complete.");
        }
    }
}
