using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductEx product = new ProductEx { Name = "Computer", Price = 399.95 };
            Console.WriteLine(product.ToString());
        }
    }
}
