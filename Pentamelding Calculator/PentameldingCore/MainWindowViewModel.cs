using Pentamelding_Calculator.Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pentamelding_Calculator.PentameldingCore
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        { 
            _calculatorViewModel = new CalculatorViewModel(); 

            CurrentView = _calculatorViewModel;
        }

        private CalculatorViewModel _calculatorViewModel { get;}
        public IMainWindow CurrentView { get; }
    }
}
