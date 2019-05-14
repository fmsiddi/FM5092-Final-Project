﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCP
{
    public class Lookback : Option
    {
        public Lookback(double[,] optionSimulatedStockPaths, double optionK, int optionSimNumber, int optionTimeSteps, bool optionCallOrPut) : base(optionSimulatedStockPaths, optionK, optionSimNumber, optionTimeSteps, optionCallOrPut)
        {
            simulatedStockPaths = optionSimulatedStockPaths;
            K = optionK;
            simNumber = optionSimNumber;
            timeSteps = optionTimeSteps;
            callOrPut = optionCallOrPut;
        }

        public override double[] terminalPayoff()
        {
            double[] terminalPayoffVector = new double[simNumber];

            for (int i = 0; i < simNumber; i++)
            {
                double[] singleSimulation = new double[timeSteps];
                for (int j = 0; j < timeSteps; j++)
                {
                    singleSimulation[j] = simulatedStockPaths[i, j];
                }

                if (callOrPut)
                {
                    terminalPayoffVector[i] = Math.Max(singleSimulation.Max() - K, 0);
                }
                else
                {
                    terminalPayoffVector[i] = Math.Max(K - singleSimulation.Max(), 0);
                }
            }
            return terminalPayoffVector;
        }
    }
}
