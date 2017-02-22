using System;

class Program
{
    public static void PrintSign(int num)
    {
        if (num == 0)
        {
            Console.WriteLine("The number {0} is zero.", num);
        }
        else if (num > 0)
        {
            Console.WriteLine("The number {0} is positive.", num);
        }
        else
        {
            Console.WriteLine("The number {0} is negative.", num);
        }
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        PrintSign(n);
    }
}

