using System;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        for (int i = 1; i <= num; i++)
        {
            int sum = 0;
            int j = i;
            Console.Write(j);
            while (j > 0)
            {
                int lastDigit = j % 10;
                sum += lastDigit;
                j = j / 10;     
            }
            if (sum == 5 || sum == 7 || sum == 11)
            {
                Console.WriteLine(" -> True");
            }
            else
            {
                Console.WriteLine(" -> False");
            }
        }
    }
}
