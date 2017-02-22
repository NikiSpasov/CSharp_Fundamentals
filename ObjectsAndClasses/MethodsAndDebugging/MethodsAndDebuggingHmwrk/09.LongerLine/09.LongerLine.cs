using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());

            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var x3 = double.Parse(Console.ReadLine());
            var y3 = double.Parse(Console.ReadLine());

            var x4 = double.Parse(Console.ReadLine());
            var y4 = double.Parse(Console.ReadLine());

            var distanceOfLine1 = CalculateLineLength(x1, y1, y2, y2);
            var distanceOfLine2 = CalculateLineLength(x3, y3, x4, y4);

            if (distanceOfLine1 >= distanceOfLine2)
            {
                PrintCloserLine(x1, y1, x2, y2);
            }
            else
            {
                PrintCloserLine(x3, y3, x4, y4);
            }
        }

        private static void PrintCloserLine(double x1, double y1, double x2, double y2)
        {
            if (IsCloserToZero(x1, y1, x2, y2))
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }

        private static bool IsCloserToZero(double x1, double y1, double x2, double y2)
        {
            double dist1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double dist2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));

            bool isCloserToZero = dist1 <= dist2;
            return isCloserToZero;
        }

        private static double CalculateLineLength(double x1, double y1, double x2, double y2)
        {
            var xLength = Math.Abs(x1 - x2);
            var yLength = Math.Abs(y1 - y2);

            var lineLength = Math.Sqrt(Math.Pow(xLength, 2) + Math.Pow(yLength, 2));
            return lineLength;
        }
    }
}
