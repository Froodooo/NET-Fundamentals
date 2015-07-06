using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using the new CalculateDiscount method
            NewOrder newOrder = new NewOrder();
            decimal newDiscount = newOrder.CalculateDiscount(100, 20);
            Console.WriteLine("First price: {0}", newDiscount);

            Order order = newOrder;
            decimal discount = order.CalculateDiscount(100, 20);
            Console.WriteLine("Second price: {0}", discount);
        }
    }
}
