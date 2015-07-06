using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_4
{
    class NewOrder : Order
    {
        public new decimal CalculateDiscount(decimal price, decimal discountPercentage)
        {
            return 2;
        }
    }
}
