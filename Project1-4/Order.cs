using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_4
{
    class Order
    {
        public virtual decimal CalculateDiscount(decimal price, decimal discountPercentage)
        {
            return (discountPercentage / 100) * price;
        }
    }
}
