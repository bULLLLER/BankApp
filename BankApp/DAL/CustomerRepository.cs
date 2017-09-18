using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApp.Models;

namespace BankApp.DAL
{
    public class CustomerRepository
    {
        private List<Customer> allCustomers;

        public CustomerRepository()
        {
            allCustomers = new List<Customer>();
        }

        public void SaveCustomer(Customer customer)
        {
            //Save the customer
            allCustomers.Add(customer);
        }

        public Customer FindCustomer(string name)
        {
            Customer result = null;
            return result;
        }


        public void DeleteCustomer(string name)
        {
            Customer customerToDelete = FindCustomer(name);
            allCustomers.Remove(customerToDelete);
        }
    }
}
