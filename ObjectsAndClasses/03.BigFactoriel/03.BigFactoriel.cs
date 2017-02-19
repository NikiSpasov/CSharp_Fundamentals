using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        BigInteger result = 1;

        for (int i = 2; i <= num; i++)
        {
            result *= i;
        }
        Console.WriteLine(result);
    }
}
