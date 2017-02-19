using System;


class Program
{
    public static void CompareTwoCharArraysAndPrintSmallerFirst(char[] firstArr, char[] secondArr)
    {
        int a = Math.Min(firstArr.Length, secondArr.Length);
        bool isEqualOrSmaller = false;
        for (int i = 0; i < a; i++)
        {
            if (firstArr[i] <= secondArr[i] && firstArr.Length <= secondArr.Length)
            {
                isEqualOrSmaller = true;
            }
            else
            {
                isEqualOrSmaller = false;
                break;
            }
        }
        if (isEqualOrSmaller)
        {
            for (int k = 0; k < firstArr.Length; k++)
            {
                Console.Write(firstArr[k]);
            }
            Console.WriteLine();
            for (int j = 0; j < secondArr.Length; j++)
            {
                Console.Write(secondArr[j]);
            }
            Console.WriteLine();
        }
        else
        {
            for (int i = 0; i < secondArr.Length; i++)
            {
                Console.Write(secondArr[i]);
            }
            Console.WriteLine();
            for (int j = 0; j < firstArr.Length; j++)
            {
                Console.Write(firstArr[j]);
            }
            Console.WriteLine();
        }
    }
    public static string RemoveWhitespace(string str)
    {
        return string.Join("", str.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
    }
    static void Main(string[] args)

    {
        string first = Console.ReadLine();
        char[] firstArr = RemoveWhitespace(first).ToCharArray();
        string second = Console.ReadLine();
        char[] secondArr = RemoveWhitespace(second).ToCharArray();
        CompareTwoCharArraysAndPrintSmallerFirst(firstArr, secondArr);
    }
}