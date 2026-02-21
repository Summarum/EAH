using EAH.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EAH.Libs
{
    internal class LibNPVCalc : INPVCalc
    {
        public double Calculate(double rate, IEnumerable<ModelCashFlow> cashFlows)
        {
            double npv = 0.0;
            foreach (var cf in cashFlows)
            {
                npv += cf.Amount / Math.Pow(1.0 + rate, cf.Period);
            }
            return npv;
        }
    }
}
