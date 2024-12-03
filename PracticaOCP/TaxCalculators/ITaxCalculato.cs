using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOCP.TaxCalculators
{
    public interface ITaxCalculator
    {
        decimal CalculateTax(decimal income, decimal deduction);
    }

}
