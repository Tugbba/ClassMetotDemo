using System;
using System.Text;
using System.Xml.Linq;

namespace ClassMetotDemo
{

    class Program
    {

        static void Main(string[] args)
        {
            Customer customer1 = new Customer
            {
                Id = 1,
                TcNo= 1111111111,
                Name = "Tuba",
                Surname = "Cinbek",
                Email = "tugbacinbek@gmail.com",
                PhoneNumber = "553-067-7078",
            };

            Customer customer2 = new Customer 
            {
                Id = 2,
                TcNo = 222222222,
                Name = "Sude",
                Surname = "Kar",
                Email = "sudekarl47@gmail.com",
                PhoneNumber = "537-066-5418",
            };
           

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1 );
            Console.WriteLine(customer1.Id+customer1.Name+ " "+ customer1.Surname);

            customerManager.List(customer1);
            Console.WriteLine(customer1.Id + customer1.Name + " " + customer1.Surname);

            customerManager.Delete(customer1);
            Console.WriteLine(customer1.Id + customer1.Name + " "+ customer1.Surname);


            Customer[] customers = new Customer[] { customer1, customer2 };
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Id);
                Console.WriteLine(customer.TcNo);
                Console.WriteLine(customer.Name);
                Console.WriteLine(customer.Surname);
                Console.WriteLine(customer.Email);
                Console.WriteLine(customer.PhoneNumber);
            }
        }
    }
    }

