using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaISP
{
    public class Siguita : IAve
    {
        public void Volar()
        {
            Console.WriteLine("La siguita está volando.");
        }

        public void Cantar()
        {
            Console.WriteLine("La siguita  está cantando.");
        }

        public void PonerHuevos()
        {
            Console.WriteLine("La siguita está poniendo huevos.");
        }
    }
}
