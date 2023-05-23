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
                NationalityId = 1111111111,
                FirstName = "Tuba",
                Lastname = "Cinbek",
                Email = "tugbacinbek@gmail.com",
                PhoneNumber = "553-067-7078",
            };

            Customer customer2 = new Customer 
            {
                Id = 2,
                NationalityId = 222222222,
                FirstName = "Sude",
                Lastname = "Kar",
                Email = "sudekarl47@gmail.com",
                PhoneNumber = "537-066-5418",
            };
           

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1 );
            Console.WriteLine(customer1.Id+customer1.FirstName+ " "+ customer1.Lastname);

            customerManager.List(customer1);
            Console.WriteLine(customer1.Id + customer1.FirstName + " " + customer1.Lastname);

            customerManager.Delete(customer1);
            Console.WriteLine(customer1.Id + customer1.FirstName + " "+ customer1.Lastname);


            Customer[] customers = new Customer[] { customer1, customer2 };
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Id);
                Console.WriteLine(customer.NationalityId);
                Console.WriteLine(customer.FirstName);
                Console.WriteLine(customer.Lastname);
                Console.WriteLine(customer.Email);
                Console.WriteLine(customer.PhoneNumber);
            }
        }
    }
    }

