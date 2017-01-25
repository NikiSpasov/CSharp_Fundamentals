using System;

class Program
{
    private static int GetMultiplpeOfEvensAndOdds(int num)
    {
        int odds = GetSumOfOdds(num);
        int evens = GetSumOfEvens(num);
        int sum = odds * evens;
        return sum;
    }
    private static int GetSumOfEvens(int num)
    {
        int sumOfEven = 0;
        if (num < 0)
        {
            num = num * -1;
        }
        while (num > 0)
        {
            int lastDigit = num % 10;
            
            if (lastDigit % 2 == 0)
            {
                sumOfEven += lastDigit;
            }
            num = num / 10;
        }
        
        return sumOfEven;
    }
    private static int GetSumOfOdds(int num)
    {
        int sumOfOdds = 0;
        if (num < 0)
        {
            num = num * -1;
        }
        while (num > 0)
        {
            if (num < 0)
            {
                num = num * -1;
            }
            int lastDigit = num % 10;
            if (lastDigit % 2 != 0)
            {
                sumOfOdds += lastDigit;
            }
            num = num / 10;
        }
        return sumOfOdds;
    }


    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int sum = GetMultiplpeOfEvensAndOdds(num);
        Console.WriteLine(sum);
    }
}


