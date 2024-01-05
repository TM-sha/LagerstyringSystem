using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagerstyringSystem
{
    internal class Foodstuff : IProduct
    {
        public DateTime Expiration { get; set; }

        public string Name { get; set; }
        public int Price { get; set; }

        public Foodstuff(string name, int price, int expiresInDays)
        {
            Expiration = DateTime.Now;
            Expiration = Expiration.AddDays(expiresInDays); 
            Name = name;
            Price = price;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {Name}\n" +
                              $"Price: {Price},- \n" +
                              $"Expires: {Expiration.ToShortDateString()}\n");
        }
    }
}
