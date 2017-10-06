using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApp.Models;

namespace BankApp.DAL
{
    // Need to implement IEnumerable for foreach looping over customers
    public class CustomerRepository : IEnumerable<Customer>
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
            foreach (Customer cust in allCustomers) {
                if (cust.Name == name) {
                    return cust;
                }
            }
            return null;
        }


        public void DeleteCustomer(string name)
        {
            Customer customerToDelete = FindCustomer(name);
            allCustomers.Remove(customerToDelete);
        }

        public IEnumerator<Customer> GetEnumerator() {
            return allCustomers.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }
    }
}
