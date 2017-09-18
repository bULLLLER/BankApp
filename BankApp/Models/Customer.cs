using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Models
{
    public class Customer
    {
        public Customer(Account myAccount)
        {
            TheAccount = myAccount;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public Account TheAccount { get; set; }
    }
}
