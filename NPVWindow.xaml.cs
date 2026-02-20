using EAH.Libs;
using EAH.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EAH
{
    /// <summary>
    /// Logika interakcji dla klasy NPVWindow.xaml
    /// </summary>
    public partial class NPVWindow : Window
    {
        private List<ModelCashFlow> cashFlowsList;
        private LibNPVCalc npvCalc;
        public NPVWindow()
        {
            InitializeComponent();
            cashFlowsList = new List<ModelCashFlow>();
            npvCalc = new LibNPVCalc();
        }
    }
}
