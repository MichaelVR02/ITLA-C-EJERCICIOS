using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOCP.TaxCalculators
{
    public class TaxCalculatorUSA : ITaxCalculator
    {
        public decimal CalculateTax(decimal income, decimal deduction)
        {
            decimal taxableIncome = income - deduction;
            decimal taxAmount = 0;

            // Logica de calculo para USA
            if (taxableIncome > 0)
            {
                // Ejemplo basico: 20% de impuestos sobre la renta imponible
                taxAmount = taxableIncome * 0.20m; // 20% de impuestos
            }

            return taxAmount;
        }
    }

}
