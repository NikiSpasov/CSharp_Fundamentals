using System;
using System.Linq;

class Program
{
    public static bool IsSymmetryc(int num)
    {
        bool isSimmetryc = false;
        char[] strNum = num.ToString().ToArray();
        for (int i = 0; i < strNum.Length / 2; i++)
        {
            if (strNum[i] == strNum[strNum.Length - 1 - i])
            {
                isSimmetryc = true;
            }
            else
            {
                isSimmetryc = false;
                break;
            }
        }
        if (strNum.Length == 1)
        {
            isSimmetryc = true;
        }
        return isSimmetryc;
    }
    public static bool SumOfDigitsDivisibeBySeven(int num)
    {
        bool divisible = false;
        int[] strNum = num.ToString().Select(t => int.Parse(t.ToString())).ToArray();
        int sum = strNum.Sum();
        if (sum % 7 == 0)
        {
            divisible = true;
        }
        return divisible;
    }
    public static bool HasEvenDigit(int num)
    {
        bool hasEven = false;
        while (num > 0)
        {
            int lastDigit = num % 10;
            if (lastDigit % 2 == 0)
            {
                hasEven = true;
                return hasEven;
            }
            num /= 10;
        }
        return hasEven;
    }
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        for (int i = 1; i < num; i++)
        {
            if (IsSymmetryc(i) && SumOfDigitsDivisibeBySeven(i) && HasEvenDigit(i))
            {
                Console.WriteLine(i);
            }
        }

    }
}

//A master number is an integer that holds the following properties:
//•	Is symmetric(palindrome), e.g. 5, 77, 282, 14341, 955559.
//•	Its sum of digits is divisible by 7, e.g. 77, 313, 464, 5225, 37173.
//•	Holds at least one even digit, e.g. 232, 707, 6886, 87578.
//Write a program to print all master numbers in the range[1…n].
