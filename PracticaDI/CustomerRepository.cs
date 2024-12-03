using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDI
{
    public class CustomerRepository
    {
        public void SaveCustomer(string customerName)
        {
            // Lógica para guardar al cliente
            Console.WriteLine($"Customer {customerName} saved to database.");
        }
    }

}
