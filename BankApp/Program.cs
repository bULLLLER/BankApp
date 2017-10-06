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
        private static CustomerRepository cr;

        public static void Main(string[] args)
        {
            cr = new CustomerRepository();
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
            switch (command) {
                case "1":
                    ShowCreateCustomer();
                    break;
                case "2":
                    PrintCustomers();
                    break;
                case "quit":
                case "q":
                case "exit":
                    Environment.Exit(0);
                    break;
                default:
                    ShowMainMenu();
                    break;
            }
        }

        public static void ShowCreateCustomer()
        {
            Console.WriteLine("--- Create a customer ---");
            Console.Write("please enter your name: ");
            //string name = Console.ReadLine();

            //create customer
            Customer customer = new Customer(new Account());
            customer.Name = Console.ReadLine();
            cr.SaveCustomer(customer);
            Console.WriteLine("New customer created!\n");

            ShowMainMenu();
        }

        public static void PrintCustomers() {
            foreach (Customer cust in cr) {
                Console.WriteLine($"Name:\t\t{cust.Name}\nBalance:\t{cust.TheAccount.Balance}\n");
            }

            ShowMainMenu();
        }
    }
}
