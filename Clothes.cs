using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagerstyringSystem
{
    internal class Clothes : IProduct
    {
        public string Size { get; set; }

        public string Name { get; set; }
        public int Price { get; set; }

        public Clothes(string name, int price, string size)
        {
            Size = size;
            Name = name;
            Price = price;
        }


        public void Print()
        {
            Console.WriteLine($"Name: {Name}\n" +
                              $"Price: {Price},- \n" +
                              $"Size: {Size}\n");
        }
    }
}
