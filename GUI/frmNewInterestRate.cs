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
    public partial class frmNewInterestRate : Form
    {
        public frmNewInterestRate()
        {
            InitializeComponent();
        }

        EntityModelContainer EMC = new EntityModelContainer();
        DB.InterestRate r = new DB.InterestRate();

        private void FrmNewInterestRate_Load(object sender, EventArgs e)
        {

        }

        private void LblNewRateTenor_Click(object sender, EventArgs e)
        {

        }

        private void LblNewRateRate_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxNewRateTenor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxNewRateRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnNewRateAdd_Click(object sender, EventArgs e)
        {
            double interestRate;

            try
            {
                interestRate = Double.Parse(textBoxNewRateRate.Text);
            }
            catch (Exception xc)
            {
                MessageBox.Show(xc.Message);
            }
            interestRate = Convert.ToDouble(textBoxNewRateRate.Text);

            r.Tenor = Convert.ToDouble(comboBoxNewRateTenor.Text) / 12;
            r.Rate = Convert.ToDouble(textBoxNewRateRate.Text) / 100;

            EMC.InterestRates.Add(r);
            EMC.SaveChanges();

            MessageBox.Show("Action Complete.");
        }
    }
}
