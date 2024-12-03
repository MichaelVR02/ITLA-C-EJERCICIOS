using PracticaISP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaISP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un Pato
            IAve pato = new Pato();
            pato.Volar();
            pato.Cantar();
            pato.PonerHuevos();
            // El pato puede nadar
            INadar patoNadar = (INadar)pato;
            patoNadar.Nadar();

            Console.WriteLine();

            // Crear un Siguita
            IAve Siguita = new Siguita();
            Siguita.Volar();
            Siguita.Cantar();
            Siguita.PonerHuevos();

            Console.WriteLine();

            // Crear un aguila
            IAve aguila = new Aguila();
            aguila.Volar();
            aguila.Cantar();
            aguila.PonerHuevos();
            // El aguila puede cazar
            ICazar aguilaCazar = (ICazar)aguila;
            aguilaCazar.Cazar();
        }
    }
}
