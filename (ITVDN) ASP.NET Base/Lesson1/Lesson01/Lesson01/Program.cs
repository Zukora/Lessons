﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01
{
    class Program
    {
        static void Main(string[] args)
        {
            Address a = new Address();
            Console.WriteLine(a.Index);
            a.Index = "privet";
            Console.WriteLine(a.Index);
            a.Index = "test";
            Console.WriteLine(a.Index);
            Console.ReadKey();
        }
    }
}
