using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestOpeartorov
{
    internal class Point
    {
        private int _x;
        private int _y;

        public static int a = 0;

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int X
        {
            get { return _x; }
        }

        public int Y
        {
            get { return _y; }
        }

        public static Point operator+(Point point1, Point point2)
        {
            return new Point(point1.X + point2.X, point1.Y + point2.Y);
        }
    }
}
