using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDI
{
    public class CustomerService
    {
        private readonly CustomerRepository _customerRepository;

        // Dependencia inyectada a través del constructor
        public CustomerService(CustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void AddCustomer(string customerName)
        {
            _customerRepository.SaveCustomer(customerName);
        }
    }


}
