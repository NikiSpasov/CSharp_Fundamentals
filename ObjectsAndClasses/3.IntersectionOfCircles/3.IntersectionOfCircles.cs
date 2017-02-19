using System;
using System.Linq;

class Program
{
    public static bool Intersect(Circle c1, Circle c2, double distance)
    {
        bool intersect;
        if (distance <= c1.Radius + c2.Radius)
        {
            intersect = true;
            return intersect;
        }
        return false;
    }
    public static double CalculateDistance(Point firstPoint, Point secondPoint)
    {
        var diffX = firstPoint.X - secondPoint.X;
        var diffY = firstPoint.Y - secondPoint.Y;

        var powX = Math.Pow(diffX, 2);
        var powY = Math.Pow(diffY, 2);
        return Math.Sqrt(powX + powY);
    }
    static void Main()
    {
        var firstCircle = Console.ReadLine().Split(' ').ToArray();
        var secondCircle = Console.ReadLine().Split(' ').ToArray();
        Point first = new Point
        {
            X = int.Parse(firstCircle[0]),
            Y = int.Parse(firstCircle[1])
        };
        Point second = new Point
        {
            X = int.Parse(secondCircle[0]),
            Y = int.Parse(secondCircle[1])
        };

        double distanceBetweenCircleCenters = CalculateDistance(first, second);
        Circle r1 = new Circle();
        r1.Radius = double.Parse(firstCircle[2]);
        Circle r2 = new Circle();
        r2.Radius = double.Parse(secondCircle[2]);
        if (Intersect(r1, r2, distanceBetweenCircleCenters))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

