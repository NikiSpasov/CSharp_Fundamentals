using System;
using System.Numerics;
class Program
{
    public static void CalcFac(int num)
    {
        BigInteger fact = 1;
        do
        {
            fact = fact * num;
            num--;
        } while (num > 1);

        Console.WriteLine(fact);
    }
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        CalcFac(num);
    }
}
//13.	* Factorial
//Write a program that calculates and prints the n! for any n in the range[1…1000].
//Examples
//Input   Output Input   Output
//5	120		100	93326215443944152681699238856266700490715968264381621468592963895217599993229
//    915608941463976156518286253697920827223758251185210916864000000000000000000000000
//Hints
//Use the class BigInteger from the built-in .NET library System.Numerics.dll.
