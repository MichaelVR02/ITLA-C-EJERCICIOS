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
            // Lógica para enviar correo electrónico (por ejemplo, usando SMTP)
            Console.WriteLine($"Enviando correo a {destinatario}: {mensaje}");
        }
    }

}
