using System;

class Program
{

    static void Main()
    {
        double num = double.Parse(Console.ReadLine());
        string whatToCalculate = Console.ReadLine();
        if (whatToCalculate == "face")
        {
            CalcFaceOfTheCube(num);
        }
        else if (whatToCalculate == "space")
        {
            CalcSpaceOfTheCube(num);
        }
        else if (whatToCalculate == "volume")
        {
            CalcVolumeOfTheCube(num);
        }
        else
        {
            CalcAreaOfTheCub(num);
        }
    }

    private static void CalcAreaOfTheCub(double num)
    {
        double area = 6 * Math.Pow(num, 2);
        Console.WriteLine("{0:f2}", area);
    }

    private static void CalcVolumeOfTheCube(double num)
    {
        double volume = Math.Pow(num, 3);
        Console.WriteLine("{0:f2}", volume);
    }

    private static void CalcSpaceOfTheCube(double num)
    {
        double space = Math.Sqrt(3 * Math.Pow(num, 2));
        Console.WriteLine("{0:f2}", space);
    }

    private static void CalcFaceOfTheCube(double num)
    {
        double face = Math.Sqrt(2 * Math.Pow(num, 2));
        Console.WriteLine("{0:f2}", face);
    }
}

//(face, space, volume or area).