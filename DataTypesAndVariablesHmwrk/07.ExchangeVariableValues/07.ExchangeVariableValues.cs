using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Before:\na = {0} \nb = {1}", a, b);
        //exchange values with bitwise opp
        a = a ^ b;
        b = b ^ a;
        a = a ^ b;
        Console.WriteLine("After: \na = {0} \nb = {1}", a, b);
    }
}
