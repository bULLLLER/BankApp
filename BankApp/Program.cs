using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApp.DAL;
using BankApp.Models;

namespace BankApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            ShowMainMenu();
            Account a = new Account();
            Customer c = new Customer(a);


            /*c.TheAccount.Balance*/
        }

        public static void ShowMainMenu()
        {
            Console.WriteLine("Welcome 2 Howie and Frederik's bank!");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1: Create a customer");
            Console.WriteLine("2: Show all customers");
            Console.WriteLine("--------------------------------------");
            String command = Console.ReadLine();
            if (command == "1")
            {
                ShowCreateCustomer();
            }
        }

        public static void ShowCreateCustomer()
        {
            Console.WriteLine("--- Create a customer ---");
            Console.Write("please enter your name: ");
            string name = Console.ReadLine();
            //create customer

            ShowMainMenu();
        }
    }
}
