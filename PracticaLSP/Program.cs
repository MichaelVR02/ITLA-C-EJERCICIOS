using PracticaLSP.LspError;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaLSP
{
    // LspCorregido

        class Program
        {
            static void Main(string[] args)
            {
                FiguraGeometrica figura1 = new Rectangulo() { Base = 5, Altura = 10 };
                FiguraGeometrica figura2 = new Cuadrado() { Lado = 5 };  // Aquí se usa Lado, no Base ni Altura

                Console.WriteLine($"Área del Rectángulo: {figura1.CalcularArea()}");  // 50
                Console.WriteLine($"Área del Cuadrado: {figura2.CalcularArea()}");    // 25
            }
        }


        /**
         * LspError
        class Program
        {
            static void Main(string[] args)
            {
                FiguraGeometrica figura1 = new Rectangulo() { Base = 5, Altura = 10 };
                FiguraGeometrica figura2 = new Cuadrado() { Base = 5, Altura = 10 };

                Console.WriteLine($"Área del Rectángulo: {figura1.CalcularArea()}");  // 50
                Console.WriteLine($"Área del Cuadrado: {figura2.CalcularArea()}");  // 25, error al usar Cuadrado
            }
        }
        **/
    }

