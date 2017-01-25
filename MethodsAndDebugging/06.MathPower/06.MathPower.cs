using System;

class Program
{
    public static double PowerOfNum(double num, int power)
    {
        double sum = 1;
        for (int i = 0; i < power; i++)
        {
            sum *= num;
        }
        return sum;
    } 
    static void Main()
    {
        double num = double.Parse(Console.ReadLine());
        int power = int.Parse(Console.ReadLine());
        double result = PowerOfNum(num, power);
        Console.WriteLine(result);
    }
}

