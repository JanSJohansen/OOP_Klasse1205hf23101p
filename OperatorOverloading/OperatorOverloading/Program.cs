using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public class Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return $"X: {x}  Y: {y}";
        }

        public static Point operator+(Point p1, Point p2)
        {
            Point pNew = new Point(p1.x + p2.x, p1.y + p2.y);
            return pNew;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point pA = new Point(6, 12);
            Point pB = new Point(16, 35);
            Point pC = pA + pB;
            //Point pD = Point.Add(pA, pB);

            Console.WriteLine(pA);
            Console.WriteLine(pB);
            Console.WriteLine(pC);

            Console.ReadLine();

        }
    }
}
