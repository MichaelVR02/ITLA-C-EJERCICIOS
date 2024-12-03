using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ahora inyectamos la dependencia manualmente
            var customerRepository = new CustomerRepository();
            var customerService = new CustomerService(customerRepository);

            customerService.AddCustomer("Juan Pérez");
        }
    }


}
