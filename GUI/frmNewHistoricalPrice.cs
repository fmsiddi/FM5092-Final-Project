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
    public partial class frmNewHistoricalPrice : Form
    {
        public frmNewHistoricalPrice()
        {
            InitializeComponent();
        }

        EntityModelContainer EMC = new EntityModelContainer();
        DB.Price p = new DB.Price();

        private void FrmNewHistoricalPrice_Load(object sender, EventArgs e)
        {
            comboBoxNewPriceTicker.DataSource = (from i in EMC.Instruments select i.UnderlyingTicker).Distinct().ToList();
        }

        private void LblNewPriceTicker_Click(object sender, EventArgs e)
        {

        }

        private void LblNewPriceDate_Click(object sender, EventArgs e)
        {

        }

        private void LblNewPricePrice_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxNewPriceTicker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxNewPriceDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxNewPricePrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePickerNewPriceDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnNewPriceAdd_Click(object sender, EventArgs e)
        {
            double closingPrice;

            try
            {
                closingPrice = Double.Parse(textBoxNewPricePrice.Text);
            }
            catch (Exception xc)
            {
                MessageBox.Show(xc.Message);
            }
            closingPrice = Convert.ToDouble(textBoxNewPricePrice.Text);

            p.Date = dateTimePickerNewPriceDate.Value.Date;
            p.ClosingPrice = closingPrice;
            p.UnderlyingTicker = comboBoxNewPriceTicker.Text;

            EMC.Prices.Add(p);
            EMC.SaveChanges();

            MessageBox.Show("Action Complete.");
        }
    }
}
