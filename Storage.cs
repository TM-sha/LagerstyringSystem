using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagerstyringSystem
{
    internal class Storage
    {
        public List<IProduct> products { get; set; }

        public Storage()
        {
            products = new List<IProduct>();
        }

        public void AddProduct(IProduct item)
        {
            products.Add(item);
        }
        public void AddProduct(List<IProduct> list)
        {
            foreach (IProduct item in list)
            {
                products.Add(item);
            }
        }

        public void RemoveProduct(IProduct item)
        {
            products.Remove(item);
        }

        public void PrintProducts()
        {
            foreach (var product in products)
            {
                product.Print();
            }
        }
    }
}
