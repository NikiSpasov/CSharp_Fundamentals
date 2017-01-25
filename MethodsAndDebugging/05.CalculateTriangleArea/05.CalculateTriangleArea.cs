using System;
class Program
{
    public static double GetTriangleArea(double width, double height)
    {
        return (width * height) / 2;
    }


    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double heigth = double.Parse(Console.ReadLine());
        double area = GetTriangleArea(width, heigth);
        Console.WriteLine(area);
    }
}

