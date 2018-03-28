using System;
using System.Linq;

class Program
{
    public static void PrintNumInReversedNum(string num)
    {
        string[] number = num.Select(x => x.ToString()).ToArray();
        string[] reversed = number.Reverse().ToArray();
        Console.WriteLine(string.Join("", reversed));
    }
    static void Main(string[] args)
    {
        string num = Console.ReadLine();
        PrintNumInReversedNum(num);
    }
}