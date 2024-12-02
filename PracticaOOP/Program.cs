using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace PracticaOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Figura rectangulo = new Rectangulo(5, 10);
            Figura circulo = new Circulo(7);
            Figura triangulo = new Triangulo(4, 8);

            Console.WriteLine($"Área del Rectángulo: {rectangulo.CalcularArea()}");
          
            Console.WriteLine($"Área del Círculo: {circulo.CalcularArea()}");
            
            Console.WriteLine($"Área del Triángulo: {triangulo.CalcularArea()}");

            
            Console.WriteLine();
            Persona persona = new Persona("Juan", 30, "Santo Domingo");
            persona.MostrarInformacion();

            Estudiante estudiante = new Estudiante("Ana", 22, "Santiago", "Ingeniería", "20221001");
            estudiante.MostrarInformacion();
        }
    }
}

