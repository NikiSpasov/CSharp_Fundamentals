using System;

class Program
{
    private static bool IsCloserToZero(double x1, double y1, double x2, double y2)
    {

        double dist1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
        double dist2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
        bool isCloserToZero = dist1 <= dist2;
        return isCloserToZero;
    }

    static void Main()
    {
        var x1 = double.Parse(Console.ReadLine());
        var y1 = double.Parse(Console.ReadLine());
        var x2 = double.Parse(Console.ReadLine());
        var y2 = double.Parse(Console.ReadLine());

        if (IsCloserToZero(x1, y1, x2, y2))
        {
            Console.WriteLine($"({x1}, {y1})");
        }
        else
        {
            Console.WriteLine($"({x2}, {y2})");
        }
    }
}


