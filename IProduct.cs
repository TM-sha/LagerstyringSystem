﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagerstyringSystem
{
    internal interface IProduct
    {
       public string Name { get; set; }
       public int Price { get; set; }

       public void Print();
    }
}
