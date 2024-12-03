using PracticaISP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaISP
{
    public class Pato : IAve, INadar
    {
        public void Volar()
        {
            Console.WriteLine("El pato está volando.");
        }

        public void Cantar()
        {
            Console.WriteLine("El pato está cantando.");
        }

        public void PonerHuevos()
        {
            Console.WriteLine("El pato está poniendo huevos.");
        }

        public void Nadar()
        {
            Console.WriteLine("El pato está nadando.");
        }
    }

}