using System;
using System.Collections.Generic;
using System.Text;


namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Id + customer.FirstName + " Eklendi.");
        }
        public void List(Customer customer)
        {
            Console.WriteLine(customer.Id + customer.FirstName + " Listelendi." );
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Id + " Kayıt silindi");
        }

    }
}
