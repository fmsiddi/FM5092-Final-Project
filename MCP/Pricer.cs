using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCP
{
    public class Pricer
    {
        public double Price(double K, double r, double T, double vol, string InstType, int simNumber, int timeSteps, bool callOrPut, string InstName, double[,] simulatedStockPaths, out double forGreeks)
        {
            double p;
            double sum = 0;
            double forGreeksSum = 0;
            double[] discountedPayoffVector;

            discountedPayoffVector = new double[simNumber];


            Option o;

            if (InstType == "EURO")
            {
                o = new Euro(simulatedStockPaths, K, simNumber, timeSteps, callOrPut);
            }
            else if (InstType == "ASIAN")
            {
                o = new Asian(simulatedStockPaths, K, simNumber, timeSteps, callOrPut);
            }
            else if (InstType == "LOOKBACK")
            {
                o = new Lookback(simulatedStockPaths, K, simNumber, timeSteps, callOrPut);
            }
            else if (InstType == "RANGE")
            {
                o = new Range(simulatedStockPaths, K, simNumber, timeSteps, callOrPut);
            }
            else if (InstType == "DIGITAL")
            {
                double digitalRebate;
                int rebateIndex = InstName.IndexOf("REBATE-");
                InstName = InstName.Substring(rebateIndex);
                digitalRebate = Convert.ToDouble(InstName.Substring(7));

                o = new Digital(simulatedStockPaths, K, simNumber, timeSteps, callOrPut, digitalRebate);
            }
            else
            {
                double barrier;
                int barrierIndex = InstName.IndexOf("BARRIER-");
                InstName = InstName.Substring(barrierIndex);
                barrier = Convert.ToDouble(InstName.Substring(8));

                o = new Barrier(simulatedStockPaths, K, simNumber, timeSteps, callOrPut, barrier, InstType);
            }

            double[] terminalPayoffVector = o.terminalPayoff();


            for (int i = 0; i < simNumber; i++)
            {
                sum += terminalPayoffVector[i];
                discountedPayoffVector[i] = terminalPayoffVector[i] * Math.Exp(-r * T);
                forGreeksSum = sum;
            }

            forGreeks = forGreeksSum / Convert.ToDouble(simNumber) * Math.Exp(-r * T);
            p = sum / Convert.ToDouble(simNumber) * Math.Exp(-r * T);

            return p;
        }
    }
}
