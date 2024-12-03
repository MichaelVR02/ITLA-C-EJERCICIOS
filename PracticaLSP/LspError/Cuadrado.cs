using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaLSP.LspError
{

    public class Cuadrado : FiguraGeometrica
    {
        public int Lado { get; internal set; }

        public override double CalcularArea()
        {
            return Base * Base;  // Esto da el área del cuadrado, pero no sigue la regla del rectángulo
        }
    }

}
