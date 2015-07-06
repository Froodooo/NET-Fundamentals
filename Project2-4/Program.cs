using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stackA = new Stack<int>();
            stackA.Push(2);
            stackA.Push(3);
            stackA.Push(4);
            stackA.Push(6);

            Stack<int> stackB = new Stack<int>();
            stackB.Push(1);
            stackB.Push(3);
            stackB.Push(5);

            Stack<int> stackResult = new Stack<int>();
            // compare and pop until one of the stacks is empty
            while (stackA.Count > 0 && stackB.Count > 0)
            {
                if (stackA.Peek() > stackB.Peek())
                {
                    stackResult.Push(stackA.Pop());
                }
                else
                {
                    stackResult.Push(stackB.Pop());
                }
            }

            // if stack A is empty, continue to pop from B until it is empty
            if (stackA.Count == 0)
            {
                while (stackB.Count > 0)
                {
                    stackResult.Push(stackB.Pop());
                }
            }
            // stack B is empty, continue to pop from A until it is empty
            else
            {
                while (stackA.Count > 0)
                {
                    stackResult.Push(stackA.Pop());
                }
            }

            // pop and print the numbers from the resulting stack
            while (stackResult.Count > 0)
            {
                Console.WriteLine(stackResult.Pop());
            }
        }
    }
}
