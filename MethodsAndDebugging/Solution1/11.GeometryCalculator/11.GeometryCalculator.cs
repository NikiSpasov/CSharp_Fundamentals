using System;

class Program
{
    static void Main()
    {
        string figureType = Console.ReadLine().ToLower();
        if (figureType == "triangle")
        {
            FindTheAreaOfTriangle();
        }
        else if (figureType == "square")
        {
            FindTheAreaOfSquare();
        }
        else if (figureType == "rectangle")
        {
            FindTheAreaOfRectangle();
        }
        else
        {
            FindTheAreaOfCircle();
        }
    }
    private static void FindTheAreaOfCircle()
    {
        double radius = double.Parse(Console.ReadLine());
        double area = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine($"{area:f2}");
    }

    private static void FindTheAreaOfSquare()
    {
        double side = double.Parse(Console.ReadLine());
        double area = Math.Pow(side, 2);
        Console.WriteLine($"{area:f2}");
    }

    private static void FindTheAreaOfRectangle()
    {
        double width = double.Parse(Console.ReadLine());
        double heigth = double.Parse(Console.ReadLine());
        double area = width * heigth;
        Console.WriteLine($"{area:f2}");

    }

    private static void FindTheAreaOfTriangle()
    {
        double side = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double area = (side * height) / 2;
        Console.WriteLine($"{area:f2}");
    }
}

//On the first line you will get the figure type.Next you will get parameters for the chosen figure, each on a different line:
//•	Triangle - side and height
//•	Square - side
//•	Rectangle - width and height
//•	Circle - radius
