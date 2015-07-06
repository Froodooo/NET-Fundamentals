using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[4, 5]
            {
                {11,7,50,45,1},
                {18,35,47,24,2},
                {89,67,84,34,3},
                {12,23,34,45,56}
            };

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                int max = Int32.MinValue;
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    max = numbers[i, j] > max ? numbers[i, j] : max;
                }
                Console.WriteLine("Largest number in row {0}: {1}", i + 1, max);
            }
        }
    }
}
