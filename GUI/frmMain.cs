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
using MCP;

namespace GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        ListViewItem lvTrades = null;
        ListViewItem lvBook = null;
        static EntityModelContainer EMC = new EntityModelContainer();

        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewInstrument I = new frmNewInstrument();
            I.Show();
        }

        private void TradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewTrade T = new frmNewTrade();
            T.Show();
        }

        private void InterestRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewInterestRate R = new frmNewInterestRate();
            R.Show();
        }

        private void HistoricalStockPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewHistoricalPrice P = new frmNewHistoricalPrice();
            P.Show();
        }

        private void LblMainVol_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxMainVol_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnMainRefresh_Click(object sender, EventArgs e)
        {
            listViewMainTradeView.Items.Clear();

            var t = (from j in EMC.Trades select j).FirstOrDefault();

            foreach (var item in (from j in EMC.Trades select j))
            {
                lvTrades = new ListViewItem(Convert.ToString(item.ID));
                lvTrades.SubItems.Add(Convert.ToString(item.BuyOrSell));
                lvTrades.SubItems.Add(Convert.ToString(item.Quantity));
                lvTrades.SubItems.Add(Convert.ToString(item.InstrumentName));
                lvTrades.SubItems.Add(Convert.ToString(item.PriceTradedAt));
                lvTrades.SubItems.Add(Convert.ToString(item.MarkToMarket));
                lvTrades.SubItems.Add(Convert.ToString(item.PnL));
                lvTrades.SubItems.Add(Convert.ToString(item.Delta));
                lvTrades.SubItems.Add(Convert.ToString(item.Gamma));
                lvTrades.SubItems.Add(Convert.ToString(item.Vega));
                lvTrades.SubItems.Add(Convert.ToString(item.Theta));
                lvTrades.SubItems.Add(Convert.ToString(item.Rho));
                listViewMainTradeView.Items.Add(lvTrades);
            }
        }

        private void BtnMainCalc_Click(object sender, EventArgs e)
        {
            int simNumber = 200000;
            int timeSteps = 10;
            RandomNumberGenerator randomComponentMatrix = new RandomNumberGenerator();
            double[,] randomMatrix;
            randomMatrix = randomComponentMatrix.PolarRejection(simNumber, timeSteps);


            foreach (ListViewItem i in listViewMainTradeView.Items)
            {
                int id = Convert.ToInt32(i.Text);
                Trade t = (from j in EMC.Trades where j.ID == id select j).FirstOrDefault();

                string InstName = Convert.ToString(t.InstrumentName);

                int multiplier;
                if (i.SubItems[1].Text == "BUY")
                {
                    multiplier = 1;
                }
                else
                {
                    multiplier = -1;
                }

                DateTime tradeDate = t.TradeDate.Date;

                double vol;

                try
                {
                    vol = Double.Parse(textBoxMainVol.Text);
                }
                catch (Exception xc)
                {
                    MessageBox.Show(xc.Message);
                }
                vol = Convert.ToDouble(textBoxMainVol.Text);

                

                string iTypeString = Convert.ToString(t.InstrumentName);
                int startIndex = iTypeString.IndexOf("_");

                string InstType;
                if (startIndex == -1)
                {
                    InstType = "STOCK";
                    string underlyingTicker = Convert.ToString(t.InstrumentName);
                    i.SubItems[5].Text = (from p in EMC.Prices where p.Date == tradeDate && p.UnderlyingTicker == underlyingTicker select p.ClosingPrice).FirstOrDefault().ToString();
                    i.SubItems[6].Text = ((from p in EMC.Prices where p.Date == tradeDate && p.UnderlyingTicker == underlyingTicker select p.ClosingPrice).FirstOrDefault() - t.PriceTradedAt).ToString();
                    i.SubItems[7].Text = (t.Quantity * multiplier).ToString();
                }

                else
                {
                    iTypeString = iTypeString.Substring(startIndex + 1);
                    int typeStringLength = iTypeString.IndexOf("_");
                    InstType = iTypeString.Substring(0, typeStringLength);

                    string underlyingString = Convert.ToString(t.InstrumentName);
                    int underlyingStringLength = underlyingString.IndexOf("_");
                    string underlyingTicker = underlyingString.Substring(0, underlyingStringLength);

                    string tenorString = Convert.ToString(t.InstrumentName);
                    int tenorIndex = tenorString.IndexOf("TENOR-");
                    tenorString = tenorString.Substring(tenorIndex);
                    tenorIndex = tenorString.IndexOf("-");
                    tenorString = tenorString.Substring(tenorIndex + 1);
                    int tenorStringLength = tenorString.IndexOf("Y");
                    tenorString = tenorString.Substring(0, tenorStringLength);
                    double tenor = Convert.ToDouble(tenorString);

                    double rate;
                    if ((from r in EMC.InterestRates where r.Tenor == tenor select r.Rate).Count() == 0)
                    {
                        double smallerRate = (from l in EMC.InterestRates
                                              orderby l.Tenor descending
                                              where l.Tenor < tenor
                                              select l.Rate).FirstOrDefault();

                        double shorterTenor = (from l in EMC.InterestRates
                                               orderby l.Tenor descending
                                               where l.Tenor < tenor
                                               select l.Tenor).FirstOrDefault();

                        double largerRate = (from l in EMC.InterestRates
                                             orderby l.Tenor ascending
                                             where l.Tenor > tenor
                                             select l.Rate).FirstOrDefault();

                        double longerTenor = (from l in EMC.InterestRates
                                              orderby l.Tenor ascending
                                              where l.Tenor > tenor
                                              select l.Rate).FirstOrDefault();

                        rate = ((largerRate - smallerRate) / (longerTenor - shorterTenor)) * (tenor - shorterTenor) + smallerRate;
                    }
                    else
                    {
                        rate = (from r in EMC.InterestRates where r.Tenor == tenor select r.Rate).FirstOrDefault();
                    }

                    string KString = Convert.ToString(t.InstrumentName);
                    int KIndex = KString.IndexOf("STRIKE-");
                    KString = KString.Substring(KIndex);
                    int KStringLength = KString.IndexOf("_");
                    KString = KString.Substring(7, KStringLength - 7);
                    double K = Convert.ToDouble(KString);

                    double s0 = (from p in EMC.Prices where p.Date == tradeDate && p.UnderlyingTicker == underlyingTicker select p.ClosingPrice).FirstOrDefault();

                    string cpString = Convert.ToString(t.InstrumentName);
                    int cpIndex = cpString.IndexOf("_");
                    cpString = cpString.Substring(cpIndex + 1);
                    cpIndex = cpString.IndexOf("_");
                    cpString = cpString.Substring(cpIndex + 1);
                    int cpStringLength = cpString.IndexOf("_");
                    cpString = cpString.Substring(0, cpStringLength);

                    bool callOrPut;
                    if (cpString == "CALL")
                    {
                        callOrPut = true;
                    }
                    else
                    {
                        callOrPut = false;
                    }

                    double deltaVol = 0.001 * vol;
                    double deltaS = 0.001 * s0;
                    double deltaR = 0.001 * rate;
                    double deltaTheta = 0.001 * tenor;

                    double price, deltaUp, deltaDown, vegaUp, vegaDown, thetaUp, rhoUp, rhoDown, Delta, Gamma, Vega, Theta, Rho, forGreeks, ignore;

                    price = Calculated(s0, K, vol, rate, tenor, simNumber, timeSteps, InstName, callOrPut, randomMatrix, InstType, out forGreeks);
                    deltaUp = Calculated(s0 + deltaS, K, vol, rate, tenor, simNumber, timeSteps, InstName, callOrPut, randomMatrix, InstType, out ignore);
                    deltaDown = Calculated(s0 - deltaS, K, vol, rate, tenor, simNumber, timeSteps, InstName, callOrPut, randomMatrix, InstType, out ignore);
                    vegaUp = Calculated(s0, K, vol + deltaVol, rate, tenor, simNumber, timeSteps, InstName, callOrPut, randomMatrix, InstType, out ignore);
                    vegaDown = Calculated(s0, K, vol - deltaVol, rate, tenor, simNumber, timeSteps, InstName, callOrPut, randomMatrix, InstType, out ignore);
                    thetaUp = Calculated(s0, K, vol, rate, tenor + deltaTheta, simNumber, timeSteps, InstName, callOrPut, randomMatrix, InstType, out ignore);
                    rhoUp = Calculated(s0, K, vol, rate + deltaR, tenor, simNumber, timeSteps, InstName, callOrPut, randomMatrix, InstType, out ignore);
                    rhoDown = Calculated(s0, K, vol, rate - deltaR, tenor, simNumber, timeSteps, InstName, callOrPut, randomMatrix, InstType, out ignore);

                    Delta = (deltaUp - deltaDown) / (2 * deltaS);
                    Gamma = (deltaUp - (2 * forGreeks) + deltaDown) / (deltaS * deltaS);
                    Vega = (vegaUp - vegaDown) / (2 * deltaVol);
                    Theta = (forGreeks - thetaUp) / deltaTheta;
                    Rho = (rhoUp - rhoDown) / (2 * deltaR);



                    i.SubItems[5].Text = ((t.Quantity * multiplier) * price).ToString();
                    i.SubItems[6].Text = ((t.Quantity * multiplier) * (price - t.PriceTradedAt)).ToString();
                    i.SubItems[7].Text = ((t.Quantity * multiplier) * Delta).ToString();
                    i.SubItems[8].Text = ((t.Quantity * multiplier) * Gamma).ToString();
                    i.SubItems[9].Text = ((t.Quantity * multiplier) * Vega).ToString();
                    i.SubItems[10].Text = ((t.Quantity * multiplier) * Theta).ToString();
                    i.SubItems[11].Text = ((t.Quantity * multiplier) * Rho).ToString();
                }

                
            }

            listViewMainBook.Items.Clear();
            double[] totalvalues = { 0, 0, 0, 0, 0, 0 };
            foreach (ListViewItem item in listViewMainTradeView.Items)
            {
                totalvalues[0] += Convert.ToDouble(item.SubItems[6].Text);
                totalvalues[1] += Convert.ToDouble(item.SubItems[7].Text);
                totalvalues[2] += Convert.ToDouble(item.SubItems[8].Text);
                totalvalues[3] += Convert.ToDouble(item.SubItems[9].Text);
                totalvalues[4] += Convert.ToDouble(item.SubItems[10].Text);
                totalvalues[5] += Convert.ToDouble(item.SubItems[11].Text);
            }

            lvBook = new ListViewItem(Convert.ToString(totalvalues[0]));
            lvBook.SubItems.Add(Convert.ToString(totalvalues[1]));
            lvBook.SubItems.Add(Convert.ToString(totalvalues[2]));
            lvBook.SubItems.Add(Convert.ToString(totalvalues[3]));
            lvBook.SubItems.Add(Convert.ToString(totalvalues[4]));
            lvBook.SubItems.Add(Convert.ToString(totalvalues[5]));
            listViewMainBook.Items.Add(lvBook);
        }

        public double Calculated(double s0, double K, double vol, double rate, double tenor, int simNumber, int timeSteps, string InstName, bool callOrPut, double[,] randomMatrix, string InstType, out double forGreeks)
        {
            Simulator simulation = new Simulator();
            double[,] simulatedStockPaths;
            simulatedStockPaths = simulation.PathSimulator(s0, vol, rate, tenor, simNumber, timeSteps, randomMatrix);

            Pricer price = new Pricer();
            double output = price.Price(K, rate, tenor, vol, InstType, simNumber, timeSteps, callOrPut, InstName, simulatedStockPaths, out forGreeks);
            return output;
        }

        private void ListViewMainBook_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListViewMainTradeView_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewMainBook.Items.Clear();
            double[] totalvalues = { 0, 0, 0, 0, 0, 0 };
            foreach (ListViewItem item in listViewMainTradeView.SelectedItems)
            {
                totalvalues[0] += Convert.ToDouble(item.SubItems[6].Text);
                totalvalues[1] += Convert.ToDouble(item.SubItems[7].Text);
                totalvalues[2] += Convert.ToDouble(item.SubItems[8].Text);
                totalvalues[3] += Convert.ToDouble(item.SubItems[9].Text);
                totalvalues[4] += Convert.ToDouble(item.SubItems[10].Text);
                totalvalues[5] += Convert.ToDouble(item.SubItems[11].Text);
            }

            lvBook = new ListViewItem(Convert.ToString(totalvalues[0]));
            lvBook.SubItems.Add(Convert.ToString(totalvalues[1]));
            lvBook.SubItems.Add(Convert.ToString(totalvalues[2]));
            lvBook.SubItems.Add(Convert.ToString(totalvalues[3]));
            lvBook.SubItems.Add(Convert.ToString(totalvalues[4]));
            lvBook.SubItems.Add(Convert.ToString(totalvalues[5]));
            listViewMainBook.Items.Add(lvBook);
        }
    }
}
