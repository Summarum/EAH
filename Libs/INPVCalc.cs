using System;
using System.Collections.Generic;
using System.Text;

namespace EAH.Libs
{
    public interface INPVCalc
    {
        double Calculate(double rate, System.Collections.Generic.IEnumerable<EAH.Models.ModelCashFlow> cashFlows);

    }
}
