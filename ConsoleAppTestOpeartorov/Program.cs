
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestOpeartorov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(1, 1);
            Point point2 = new Point(2, 3);

            Point point3 = point1 + point2;

            Console.ReadKey();
        }
    }
}
