using System;

class Program
{
    private static bool IsPrime(long n)
    {
        bool isPrime = true;
        if (n < 2)
        {
            isPrime = false;
            return isPrime;
        }
        else if (n == 2)
        {
            return isPrime;
        }
        for (long i = n - 1; i > 1; i--)
        {
            if (n % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        return isPrime;
    }

    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        bool prime = IsPrime(n);
        Console.WriteLine(prime);
    }
}
