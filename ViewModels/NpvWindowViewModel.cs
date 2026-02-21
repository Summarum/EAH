using EAH.Models;
using EAH.Libs;
using System.Collections.ObjectModel;

namespace EAH.ViewModels
{
    public class NpvWindowViewModel : ViewModelBase
    {
        private readonly INPVCalc _npvCalc;
        public ObservableCollection<ModelCashFlow> CashFlows { get; } = new();

        public NpvWindowViewModel(INPVCalc npvCalc)
        {
            _npvCalc = npvCalc;
            
            CashFlows.Add(new ModelCashFlow { Period = 0, Amount = -1000 });
            CashFlows.Add(new ModelCashFlow { Period = 1, Amount = 600 });
            CashFlows.Add(new ModelCashFlow { Period = 2, Amount = 600 });
        }

        public double CalculateNpv(double rate) => _npvCalc.Calculate(rate, CashFlows);
    }
}