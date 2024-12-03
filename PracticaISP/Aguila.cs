using PracticaISP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaISP
{
    public class Aguila : IAve, ICazar
    {
        public void Volar()
        {
            Console.WriteLine("El aguila está volando.");
        }

        public void Cantar()
        {
            Console.WriteLine("El aguila está cantando.");
        }

        public void PonerHuevos()
        {
            Console.WriteLine("El aguila está poniendo huevos.");
        }

        public void Cazar()
        {
            Console.WriteLine("El aguila está cazando.");
        }
    }

}
