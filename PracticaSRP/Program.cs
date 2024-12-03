using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaSRP
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Persona persona = new Persona("Michael", 22, "La Romana", "michael@ejemplo.com");
           
            persona.ImprimirDatos();

            CorreoElectronico correo = new CorreoElectronico();

            correo.EnviarCorreoElectronico(persona.CorreoElectronico, "Hola, ¿cómo estás?");
        }
    }

}
