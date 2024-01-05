using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagerstyringSystem
{
    internal class Electronics : IProduct
    {
        public int Warranty { get; set; }

        public string Name { get; set; }
        public int Price { get; set; }
        
        public Electronics(string name, int price, int warranty)
        {
            Warranty = warranty;
            Name = name;
            Price = price;
        }


        public void Print()
        {
            Console.WriteLine($"Name: {Name}\n" +
                              $"Price: {Price},- \n" +
                              $"Warranty: {Warranty} Months\n");
        }
    }
}
