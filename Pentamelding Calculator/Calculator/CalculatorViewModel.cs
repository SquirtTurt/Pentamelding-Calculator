using Pentamelding_Calculator.PentameldingCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pentamelding_Calculator.Calculator
{
    public class CalculatorViewModel: IMainWindow
    {
        public CalculatorViewModel()
        {
            Melding = new Melding();
        }

        public Melding Melding { get; private set; }
    }
}
