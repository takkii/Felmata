using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Felmata
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} \nEmail: {2}", FirstName, LastName, EmailAddress);
        }
    }
    public class Tester
    {
        static void Main(string[] args)
        {
            List<Customer> customers = CreateCustomerList();

            IEnumerable<Customer> result = from customer in customers
                                           where customer.FirstName == "Donna"
                                           select customer;
            Console.WriteLine("FirstName == \"Donna\"");
                foreach(Customer customer in result)
                    Console.WriteLine(customer.ToString());

                customers[3].FirstName = "Donna";
                Console.WriteLine("FirstName == \"Donna\"research");
                foreach (Customer customer in result)
                    Console.WriteLine(customer.ToString());
        }

        private static List<Customer> CreateCustomerList()
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer { FirstName = "Orlando",
                LastName = "Gee",
                EmailAddress = "orlando0@adventure-work.com"},
                new Customer { FirstName = "Keith",
                LastName = "Harris",
                EmailAddress = "keith0@adventure-work.com"},
                new Customer { FirstName = "Donna",
                LastName = "Carreras",
                EmailAddress = "donna0@adventure-work.com"},
                new Customer { FirstName = "Janet",
                LastName = "Gates",
                EmailAddress = "janet1@adventure-work.com"},
                new Customer { FirstName = "Lucy",
                LastName = "Harrington",
                EmailAddress = "lucy0@adventure-work.com"},
            };
            return customers;
        }
    }
}
