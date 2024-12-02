using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOOP
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Ciudad { get; set; }

        public Persona(string nombre, int edad, string ciudad)
        {
            Nombre = nombre;
            Edad = edad;
            Ciudad = ciudad;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, Ciudad: {Ciudad}");
        }

        public void CalcularEdadEnAños()
        {
            Console.WriteLine($"La persona tiene {Edad} años.");
        }
    }
}
