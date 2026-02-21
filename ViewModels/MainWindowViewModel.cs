using EAH.Libs;
using System.Windows.Input;

namespace EAH.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly INPVCalc _npvCalculator;

        public MainWindowViewModel(INPVCalc npvCalculator)
        {
            _npvCalculator = npvCalculator;
        }

        
        private string _title = "EASY Accountant Helper";
        public string Title
        {
            get => _title;
            set { _title = value; Raise(); }
        }
    }
}