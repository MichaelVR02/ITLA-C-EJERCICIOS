using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaSRP
{
    public class CorreoElectronico
    {
        public void EnviarCorreoElectronico(string destinatario, string mensaje)
        {
            
            Console.WriteLine($"Enviando correo a {destinatario}: {mensaje}");
        }
    }

}
