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
    public partial class frmNewInstrument : Form
    {
        public frmNewInstrument()
        {
            InitializeComponent();
        }

        private void LblNewInstInstType_Click(object sender, EventArgs e)
        {

        }
        private void RadioButton7_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxNewInstCallOrPut.Enabled = radioButtonNewInstUpAndIn.Checked;
            comboBoxNewInstUnderlyingTicker.Enabled = radioButtonNewInstUpAndIn.Checked;
            radioButtonNewInstCall.Enabled = radioButtonNewInstUpAndIn.Checked;
            radioButtonNewInstPut.Enabled = radioButtonNewInstUpAndIn.Checked;
            textBoxNewInstStrike.Enabled = radioButtonNewInstUpAndIn.Checked;
            textBoxNewInstTenor.Enabled = radioButtonNewInstUpAndIn.Checked;
            textBoxNewInstBarrier.Enabled = radioButtonNewInstUpAndIn.Checked;
        }
        private void GroupBoxNewInstInstType_Enter(object sender, EventArgs e)
        {

        }
        private void RadioButtonNewInstStock_CheckedChanged(object sender, EventArgs e)
        {
            textBoxNewInstCompanyName.Enabled = radioButtonNewInstStock.Checked;
            textBoxNewInstStockTicker.Enabled = radioButtonNewInstStock.Checked;
        }
        private void RadioButtonNewInstEuro_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxNewInstCallOrPut.Enabled = radioButtonNewInstEuro.Checked;
            radioButtonNewInstCall.Enabled = radioButtonNewInstEuro.Checked;
            radioButtonNewInstPut.Enabled = radioButtonNewInstEuro.Checked;
            comboBoxNewInstUnderlyingTicker.Enabled = radioButtonNewInstEuro.Checked;
            textBoxNewInstStrike.Enabled = radioButtonNewInstEuro.Checked;
            textBoxNewInstTenor.Enabled = radioButtonNewInstEuro.Checked;
        }
        private void RadioButtonNewInstAsian_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxNewInstCallOrPut.Enabled = radioButtonNewInstAsian.Checked;
            radioButtonNewInstCall.Enabled = radioButtonNewInstAsian.Checked;
            radioButtonNewInstPut.Enabled = radioButtonNewInstAsian.Checked;
            comboBoxNewInstUnderlyingTicker.Enabled = radioButtonNewInstAsian.Checked;
            textBoxNewInstStrike.Enabled = radioButtonNewInstAsian.Checked;
            textBoxNewInstTenor.Enabled = radioButtonNewInstAsian.Checked;
        }
        private void RadioButtonNewInstLookback_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxNewInstCallOrPut.Enabled = radioButtonNewInstLookback.Checked;
            radioButtonNewInstCall.Enabled = radioButtonNewInstLookback.Checked;
            radioButtonNewInstPut.Enabled = radioButtonNewInstLookback.Checked;
            comboBoxNewInstUnderlyingTicker.Enabled = radioButtonNewInstLookback.Checked;
            textBoxNewInstStrike.Enabled = radioButtonNewInstLookback.Checked;
            textBoxNewInstTenor.Enabled = radioButtonNewInstLookback.Checked;
        }
        private void RadioButtonNewInstRange_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxNewInstCallOrPut.Enabled = radioButtonNewInstRange.Checked;
            radioButtonNewInstCall.Enabled = radioButtonNewInstRange.Checked;
            radioButtonNewInstPut.Enabled = radioButtonNewInstRange.Checked;
            comboBoxNewInstUnderlyingTicker.Enabled = radioButtonNewInstRange.Checked;
            textBoxNewInstStrike.Enabled = radioButtonNewInstRange.Checked;
            textBoxNewInstTenor.Enabled = radioButtonNewInstRange.Checked;
        }
        private void RadioButtonNewInstDigital_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxNewInstCallOrPut.Enabled = radioButtonNewInstDigital.Checked;
            radioButtonNewInstCall.Enabled = radioButtonNewInstDigital.Checked;
            radioButtonNewInstPut.Enabled = radioButtonNewInstDigital.Checked;
            comboBoxNewInstUnderlyingTicker.Enabled = radioButtonNewInstDigital.Checked;
            textBoxNewInstStrike.Enabled = radioButtonNewInstDigital.Checked;
            textBoxNewInstTenor.Enabled = radioButtonNewInstDigital.Checked;
            textBoxNewInstRebate.Enabled = radioButtonNewInstDigital.Checked;
        }
        private void RadioButtonUpAndOut_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxNewInstCallOrPut.Enabled = radioButtonUpAndOut.Checked;
            radioButtonNewInstCall.Enabled = radioButtonUpAndOut.Checked;
            radioButtonNewInstPut.Enabled = radioButtonUpAndOut.Checked;
            comboBoxNewInstUnderlyingTicker.Enabled = radioButtonUpAndOut.Checked;
            textBoxNewInstStrike.Enabled = radioButtonUpAndOut.Checked;
            textBoxNewInstTenor.Enabled = radioButtonUpAndOut.Checked;
            textBoxNewInstBarrier.Enabled = radioButtonUpAndOut.Checked;
        }
        private void RadioButtonNewInstDownAndIn_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxNewInstCallOrPut.Enabled = radioButtonNewInstDownAndIn.Checked;
            radioButtonNewInstCall.Enabled = radioButtonNewInstDownAndIn.Checked;
            radioButtonNewInstPut.Enabled = radioButtonNewInstDownAndIn.Checked;
            comboBoxNewInstUnderlyingTicker.Enabled = radioButtonNewInstDownAndIn.Checked;
            textBoxNewInstStrike.Enabled = radioButtonNewInstDownAndIn.Checked;
            textBoxNewInstTenor.Enabled = radioButtonNewInstDownAndIn.Checked;
            textBoxNewInstBarrier.Enabled = radioButtonNewInstDownAndIn.Checked;
        }
        private void RadioButtonNewInstDownAndOut_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxNewInstCallOrPut.Enabled = radioButtonNewInstDownAndOut.Checked;
            radioButtonNewInstCall.Enabled = radioButtonNewInstDownAndOut.Checked;
            radioButtonNewInstPut.Enabled = radioButtonNewInstDownAndOut.Checked;
            comboBoxNewInstUnderlyingTicker.Enabled = radioButtonNewInstDownAndOut.Checked;
            textBoxNewInstStrike.Enabled = radioButtonNewInstDownAndOut.Checked;
            textBoxNewInstTenor.Enabled = radioButtonNewInstDownAndOut.Checked;
            textBoxNewInstBarrier.Enabled = radioButtonNewInstDownAndOut.Checked;
        }
        private void LblNewInstStockTicker_Click(object sender, EventArgs e)
        {

        }
        private void LblNewInstCompName_Click(object sender, EventArgs e)
        {

        }
        private void LblNewInstStockPrice_Click(object sender, EventArgs e)
        {

        }
        private void LblNewInstStrike_Click(object sender, EventArgs e)
        {

        }
        private void LblNewInstTenor_Click(object sender, EventArgs e)
        {

        }
        private void LblNewInstRebate_Click(object sender, EventArgs e)
        {

        }
        private void LblNewInstBarrier_Click(object sender, EventArgs e)
        {

        }
        private void TextBoxNewInstStockTicker_TextChanged(object sender, EventArgs e)
        {

        }
        private void TextBoxNewInstCompanyName_TextChanged(object sender, EventArgs e)
        {

        }
        private void TextBoxNewInstStockPrice_TextChanged(object sender, EventArgs e)
        {

        }
        private void TextBoxNewInstStrike_TextChanged(object sender, EventArgs e)
        {

        }
        private void TextBoxNewInstTenor_TextChanged(object sender, EventArgs e)
        {

        }
        private void TextBoxNewInstRebate_TextChanged(object sender, EventArgs e)
        {

        }
        private void TextBoxNewInstBarrier_TextChanged(object sender, EventArgs e)
        {

        }
        private void GroupBoxNewInstCallOrPut_Enter(object sender, EventArgs e)
        {

        }
        private void RadioButtonNewInstCall_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void RadioButtonNewInstPut_CheckedChanged(object sender, EventArgs e)
        {

        }

        EntityModelContainer EMC = new EntityModelContainer();
        DB.Instrument i = new DB.Instrument();

        private void FrmNewInstrument_Load(object sender, EventArgs e)
        {
            comboBoxNewInstUnderlyingTicker.DataSource = (from i in EMC.Instruments select i.UnderlyingTicker).Distinct().ToList();
        }

        private void LblNewInstUnderlyingTicker_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxNewInstUnderlyingTicker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnNewInstrumentAdd_Click(object sender, EventArgs e)
        {
            string callOrPut;

            if (radioButtonNewInstCall.Checked)
            {
                callOrPut = "CALL";
            }
            else
            {
                callOrPut = "PUT";
            }

            if (radioButtonNewInstStock.Checked)
            {
                string stockTicker = textBoxNewInstStockTicker.Text;
                string companyName = textBoxNewInstCompanyName.Text;


                i.UnderlyingTicker = stockTicker;
                i.Strike = null;
                i.Tenor = null;
                i.CallOrPut = null;
                i.InstType = "STOCK";
                i.Rebate = null;
                i.Barrier = null;
                i.InstrumentTicker = stockTicker;
                i.UnderlyingName = companyName;
            }

            else
            {
                string underlyingTicker = comboBoxNewInstUnderlyingTicker.Text;

                double strike, tenor;
                try
                {
                    strike = Double.Parse(textBoxNewInstStrike.Text);
                    tenor = Double.Parse(textBoxNewInstTenor.Text);
                }
                catch (Exception xc)
                {
                    MessageBox.Show(xc.Message);
                }
                strike = Convert.ToDouble(textBoxNewInstStrike.Text);
                tenor = Convert.ToDouble(textBoxNewInstTenor.Text);

                i.UnderlyingTicker = underlyingTicker;
                i.Strike = strike;
                i.Tenor = tenor;
                i.CallOrPut = callOrPut;
                
                i.UnderlyingName = (from n in EMC.Instruments where n.UnderlyingTicker == i.UnderlyingTicker select n.UnderlyingName).FirstOrDefault().ToString();

                if (radioButtonNewInstEuro.Checked)
                {
                    i.InstType = "EURO";
                    i.Rebate = null;
                    i.Barrier = null;
                    i.InstrumentTicker = underlyingTicker + "_EURO_" + callOrPut + "_OPT_STRIKE-" + textBoxNewInstStrike.Text + "_TENOR-" + textBoxNewInstTenor.Text + "Y";
                }

                if (radioButtonNewInstAsian.Checked)
                {
                    i.InstType = "ASIAN";
                    i.Rebate = null;
                    i.Barrier = null;
                    i.InstrumentTicker = underlyingTicker + "_ASIAN_" + callOrPut + "_OPT_STRIKE-" + textBoxNewInstStrike.Text + "_TENOR-" + textBoxNewInstTenor.Text + "Y";
                }

                if (radioButtonNewInstLookback.Checked)
                {
                    i.InstType = "LOOKBACK";
                    i.Rebate = null;
                    i.Barrier = null;
                    i.InstrumentTicker = underlyingTicker + "_LOOKBACK_" + callOrPut + "_OPT_STRIKE-" + textBoxNewInstStrike.Text + "_TENOR-" + textBoxNewInstTenor.Text + "Y";
                }

                if (radioButtonNewInstRange.Checked)
                {
                    i.InstType = "RANGE";
                    i.Rebate = null;
                    i.Barrier = null;
                    i.InstrumentTicker = underlyingTicker + "_RANGE_" + callOrPut + "_OPT_STRIKE-" + textBoxNewInstStrike.Text + "_TENOR-" + textBoxNewInstTenor.Text + "Y";
                }

                if (radioButtonNewInstDigital.Checked)
                {
                    i.InstType = "DIGITAL";

                    double rebate;
                    try
                    {
                        rebate = Double.Parse(textBoxNewInstRebate.Text);
                    }
                    catch (Exception xc)
                    {
                        MessageBox.Show(xc.Message);
                    }
                    rebate = Convert.ToDouble(textBoxNewInstRebate.Text);

                    i.Rebate = rebate;
                    i.Barrier = null;
                    i.InstrumentTicker = underlyingTicker + "_DIGITAL_" + callOrPut + "_OPT_STRIKE-" + textBoxNewInstStrike.Text + "_TENOR-" + textBoxNewInstTenor.Text + "Y_REBATE-" + textBoxNewInstRebate.Text;
                }

                if (radioButtonNewInstUpAndIn.Checked)
                {
                    i.InstType = "UP-AND-IN";

                    double barrier;
                    try
                    {
                        barrier = Double.Parse(textBoxNewInstBarrier.Text);
                    }
                    catch (Exception xc)
                    {
                        MessageBox.Show(xc.Message);
                    }
                    barrier = Convert.ToDouble(textBoxNewInstBarrier.Text);

                    i.Rebate = null;
                    i.Barrier = barrier;
                    i.InstrumentTicker = underlyingTicker + "_UP-AND-IN_" + callOrPut + "_OPT_STRIKE-" + textBoxNewInstStrike.Text + "_TENOR-" + textBoxNewInstTenor.Text + "Y_BARRIER-" + textBoxNewInstBarrier.Text;
                }

                if (radioButtonUpAndOut.Checked)
                {
                    i.InstType = "UP-AND-OUT";

                    double barrier;
                    try
                    {
                        barrier = Double.Parse(textBoxNewInstBarrier.Text);
                    }
                    catch (Exception xc)
                    {
                        MessageBox.Show(xc.Message);
                    }
                    barrier = Convert.ToDouble(textBoxNewInstBarrier.Text);

                    i.Rebate = null;
                    i.Barrier = barrier;
                    i.InstrumentTicker = underlyingTicker + "_UP-AND-OUT_" + callOrPut + "_OPT_STRIKE-" + textBoxNewInstStrike.Text + "_TENOR-" + textBoxNewInstTenor.Text + "Y_BARRIER-" + textBoxNewInstBarrier.Text;
                }

                if (radioButtonNewInstDownAndIn.Checked)
                {
                    i.InstType = "DOWN-AND-IN";

                    double barrier;
                    try
                    {
                        barrier = Double.Parse(textBoxNewInstBarrier.Text);
                    }
                    catch (Exception xc)
                    {
                        MessageBox.Show(xc.Message);
                    }
                    barrier = Convert.ToDouble(textBoxNewInstBarrier.Text);

                    i.Rebate = null;
                    i.Barrier = barrier;
                    i.InstrumentTicker = underlyingTicker + "_DOWN-AND-IN_" + callOrPut + "_OPT_STRIKE-" + textBoxNewInstStrike.Text + "_TENOR-" + textBoxNewInstTenor.Text + "Y_BARRIER-" + textBoxNewInstBarrier.Text;
                }

                if (radioButtonNewInstDownAndOut.Checked)
                {
                    i.InstType = "DOWN-AND-OUT";

                    double barrier;
                    try
                    {
                        barrier = Double.Parse(textBoxNewInstBarrier.Text);
                    }
                    catch (Exception xc)
                    {
                        MessageBox.Show(xc.Message);
                    }
                    barrier = Convert.ToDouble(textBoxNewInstBarrier.Text);

                    i.Rebate = null;
                    i.Barrier = barrier;
                    i.InstrumentTicker = underlyingTicker + "_DOWN-AND-OUT_" + callOrPut + "_OPT_STRIKE-" + textBoxNewInstStrike.Text + "_TENOR-" + textBoxNewInstTenor.Text + "Y_BARRIER-" + textBoxNewInstBarrier.Text;
                }

            }
            
            EMC.Instruments.Add(i);
            EMC.SaveChanges();

            MessageBox.Show("Action Complete.");
        }
    }
}
