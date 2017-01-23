using System;

class Program
{
    static void Main()
    {
        int countOfNumbes = int.Parse(Console.ReadLine());
        decimal sum = 0m;
        while (countOfNumbes > 0)
        {
            decimal num = decimal.Parse(Console.ReadLine());
            sum += num;
            countOfNumbes--;
        }
        Console.WriteLine(sum);
    }
}
