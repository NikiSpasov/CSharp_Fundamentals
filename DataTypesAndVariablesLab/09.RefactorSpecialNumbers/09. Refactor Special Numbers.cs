using System;
class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int sum = 0;
        bool isSpecial = false;
        int tempNum = 0;
        for (int i = 1; i <= num; i++)
        {
            tempNum = i;
            while (i > 0)
            {
                sum += i % 10;
                i = i / 10;
            }
            isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
            Console.WriteLine($"{tempNum} -> {isSpecial}");
            sum = 0;
            i = tempNum;
        }
    }
}

