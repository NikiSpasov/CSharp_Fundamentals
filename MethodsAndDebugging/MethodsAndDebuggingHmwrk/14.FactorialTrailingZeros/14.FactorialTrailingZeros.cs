using System;
using System.Numerics;

class Program
{
    public static BigInteger CalcFac(int num)
    {
        BigInteger fact = 1;
        do
        {
            fact = fact * num;
            num--;
        } while (num > 1);

        return fact;
    }
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        BigInteger fact = CalcFac(num);
        int cnt = 0;
        while (fact % 10 == 0)
        {
            cnt++;
            fact = fact / 10;
        }
        Console.WriteLine(cnt);
    }
}

