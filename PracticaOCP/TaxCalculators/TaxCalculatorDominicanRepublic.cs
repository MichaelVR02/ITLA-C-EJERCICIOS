using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOCP.TaxCalculators
{
    public class TaxCalculatorDominicanRepublic : ITaxCalculator
    {
        public decimal CalculateTax(decimal income, decimal deduction)
        {
            decimal taxableIncome = income - deduction;
            decimal taxAmount = 0;

            // Logica de cálculo para República Dominicana
            if (taxableIncome > 0)
            {
                // Ejemplo basico: se aplica un 15% de impuestos sobre la renta imponible
                taxAmount = taxableIncome * 0.15m; // 15% de impuestos
            }

            return taxAmount;
        }
    }

}
