using System;
using System.Linq;


class Program
{
    public static double CalculateDistance(Point firstPoint, Point secondPoint)
    {
        var diffX = firstPoint.X - secondPoint.X;
        var diffY = firstPoint.Y -secondPoint.Y;

        var powX = Math.Pow(diffX, 2);
        var powY = Math.Pow(diffY, 2);
        return Math.Sqrt(powX + powY);
    }
    static void Main()
    {
        var firstPointParts = Console.ReadLine()
            .Split(' ')
            .Select(x => double.Parse(x))
            .ToArray();
        var secondPointParts = Console.ReadLine()
            .Split(' ')
            .Select(x => double.Parse(x))
            .ToArray();

        var firstPoint = new Point
        {
            X = firstPointParts[0],
            Y = firstPointParts[1]
        };

        var secondPoint = new Point
        {
            X = secondPointParts[0],
            Y = secondPointParts[1]
        };
        var Calculate = CalculateDistance(
            firstPoint,
            secondPoint);
        Console.WriteLine($"{Calculate:F3}");
    }
}


