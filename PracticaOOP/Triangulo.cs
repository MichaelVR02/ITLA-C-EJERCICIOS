using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOOP
{
    public class Triangulo : Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Triangulo(double baseTriangulo, double altura)
        {
            Base = baseTriangulo;
            Altura = altura;
        }

        public override double CalcularArea()
        {
            return (Base * Altura) / 2;
        }
    }
}
