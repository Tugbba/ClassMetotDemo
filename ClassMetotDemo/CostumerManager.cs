using System;
using System.Collections.Generic;
using System.Text;


namespace ClassMetotDemo
{
    class CostumerManager
    {
        public void Add(Costumer costumer)
        {
            Console.WriteLine(costumer.Id + costumer.Name + " Eklendi.");
        }
        public void List(Costumer costumer)
        {
            Console.WriteLine(costumer.Id + costumer.Name + " Listelendi." );
        }
        public void Delete(Costumer costumer)
        {
            Console.WriteLine(costumer.Id + " Kayıt silindi");
        }

    }
}
