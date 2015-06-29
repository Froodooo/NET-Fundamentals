using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_3
{
    class ProductEx
    {
        public String Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return String.Format("{0} costs {1} euros", Name, Price);
        }
    }
}
