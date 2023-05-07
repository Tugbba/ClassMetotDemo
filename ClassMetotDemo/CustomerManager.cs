using System;
using System.Collections.Generic;
using System.Text;


namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Id + customer.Name + " Eklendi.");
        }
        public void List(Customer customer)
        {
            Console.WriteLine(customer.Id + customer.Name + " Listelendi." );
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Id + " Kayıt silindi");
        }

    }
}
