using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(1, 2, 3);
            Console.WriteLine(r.PerimeterCalculator());
            Console.WriteLine(r.AreaCalculator());
            Console.ReadKey();
        }
    }
}
