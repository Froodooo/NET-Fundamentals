﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleClass sample = new SampleClass();
            sample.SampleEvent += new SampleDelegate(Event_Triggered);
        }

        static void Event_Triggered()
        {
            Console.WriteLine("Event triggered!");
        }
    }
}
