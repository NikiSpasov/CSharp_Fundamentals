using System;

class Program
{
    static void Main()
    {
        double height = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());

        Console.WriteLine(2 * height + 2 * width);
        Console.WriteLine(height * width);
        Console.WriteLine(Math.Sqrt(Math.Pow(height, 2) + Math.Pow(width, 2)));
    }
}

