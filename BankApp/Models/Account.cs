using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Models
{
    public class Account
    {
        public Account()
        {
            Balance = 10;

        }

        public int ID { get; set; }
        public double Balance { get; set; }
    }
}
