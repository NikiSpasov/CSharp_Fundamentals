using System;

class Program
{
    public static string FindFibonacciNum(int n)
    {
        int a = 0;
        int b = 1;
        int sum = 0;
        if (n == 0)
        {
            return "1";
        }
        if (n == 1)
        {
            return "1";
        }
        else if (n == 2)
        {
            return "2";
        }
        else if (n == 3)
        {
            return "3";
        }
        int totalSum = 0;
        for (int i = 0; i < n - 2; i++)
        {
            sum = a + b;
            a = b;
            b = sum;
            totalSum += sum;
        }
        totalSum = totalSum + 2;
        return totalSum.ToString();
    }
    
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string total = FindFibonacciNum(n);
        Console.WriteLine(total);
    }
}
