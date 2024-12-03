using PracticaOCP.TaxCalculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOCP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ingresos y deducción del usuario
            decimal income = 50000m; //  ingresos
            decimal deduction = 10000m; // deducción

            // El país del usuario
            string country = "República Dominicana"; 

            // Crear el objeto adecuado según el país
            ITaxCalculator taxCalculator;

            switch (country)
            {
                case "República Dominicana":
                    taxCalculator = new TaxCalculatorDominicanRepublic();
                    break;

                case "USA":
                    taxCalculator = new TaxCalculatorUSA();
                    break;

                default:
                    throw new Exception("País no soportado");
            }

            // Calcular impuestos
            decimal taxAmount = taxCalculator.CalculateTax(income, deduction);

            // Mostrar el resultado
            Console.WriteLine($"El monto de impuestos a pagar en {country} es: {taxAmount}");
        }
    }
}
