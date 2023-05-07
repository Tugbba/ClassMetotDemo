using System;
using System.Text;
using System.Xml.Linq;

namespace ClassMetotDemo
{

    class Program
    {

        static void Main(string[] args)
        {
            Costumer costumer1 = new Costumer
            {
                Id = 1,
                IdentificationNumber = 1111111111,
                Name = "Tuba",
                Surname = "Cinbek",
                Email = "tugbacinbek@gmail.com",
                PhoneNumber = "553-067-7078",
            };

            Costumer costumer2 = new Costumer 
            {
                Id = 2,
                IdentificationNumber = 222222222,
                Name = "Sude",
                Surname = "Kar",
                Email = "sudekarl47@gmail.com",
                PhoneNumber = "537-066-5418",
            };
           

            CostumerManager costumerManager = new CostumerManager();

            costumerManager.Add(costumer1 );
            Console.WriteLine(costumer1.Id+costumer1.Name+ " "+ costumer1.Surname);

            costumerManager.List(costumer1);
            Console.WriteLine(costumer1.Id + costumer1.Name + " " + costumer1.Surname);

            costumerManager.Delete(costumer1);
            Console.WriteLine(costumer1.Id + costumer1.Name + " "+ costumer1.Surname);


            Costumer[] costumers = new Costumer[] { costumer1, costumer2 };
            foreach (Costumer costumer in costumers)
            {
                Console.WriteLine(costumer.Id);
                Console.WriteLine(costumer.IdentificationNumber);
                Console.WriteLine(costumer.Name);
                Console.WriteLine(costumer.Surname);
                Console.WriteLine(costumer.Email);
                Console.WriteLine(costumer.PhoneNumber);
            }
        }
    }
    }

