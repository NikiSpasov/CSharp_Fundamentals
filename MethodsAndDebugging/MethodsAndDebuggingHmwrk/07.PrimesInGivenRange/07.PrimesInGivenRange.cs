using System;
using System.Collections.Generic;

class Program
{
    private static int PrintPrimeNumber(int n)
    {
        bool isPrime = true;
        if (n == 2)
        {
            return 2;
        }
        for (long i = n - 1; i > 1; i--)
        {
            if (n % i == 0)
            {
                isPrime = false;
            }
        }
        if (isPrime == true)
        {
            return n;
        }
    }
    private static List<int> FindPrimesInRange(int startNum, int endNum)
    {
        List<int> myList = new List<int>();

        for (int i = startNum; i <= endNum; i++)
        {
            int primes = PrintPrimeNumber(i);
            myList.Add(primes);
        }
        return myList;
    }

    static void Main()
    {
        int startNum = int.Parse(Console.ReadLine());
        int endNum = int.Parse(Console.ReadLine());
        FindPrimesInRange(startNum, endNum);

    }
}

