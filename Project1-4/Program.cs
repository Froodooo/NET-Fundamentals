using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_4
{
    class Program : Order
    {
        static void Main(string[] args)
        {
            // Using the new CalculateDiscount method
            Order o1 = new Order();
            decimal d1 = o1.CalculateDiscount(100, 20);
            Console.WriteLine("First price: {0}", d1);

            Order o2 = o1;
            decimal d2 = o2.CalculateDiscount(100, 20);
            Console.WriteLine("Second price: {0}", d2);
        }

        public new decimal CalculateDiscount(decimal price, decimal discountPercentage)
        {
            return discountPercentage * price;
        }
    }
}
