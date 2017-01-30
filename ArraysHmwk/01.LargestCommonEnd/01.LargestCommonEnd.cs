using System;

class Program
{
    static void Main()
    {
        string[] first = Console.ReadLine().Split(' ');
        string[] second = Console.ReadLine().Split(' ');
        int minLenght;
        if (first.Length >= second.Length)
        {
            minLenght = second.Length - 1;
        }
        else
        {
            minLenght = first.Length - 1;
        }

        int cnt = 0;
        for (int i = 0; i <= minLenght; i++)
        {
            if (first[i] == second[i])
            {
                cnt++;
            }
            else
            {
                break;
            }
        }
        int cnt1 = 0;
        for (int i = 0; i <= minLenght; i++)
        {
            if (first[first.Length - 1 - i] == second[second.Length - 1 - i])
            {
                cnt1++;
            }
            else
            {
                break;
            }
        }
        int maxCnt = 0;
        if (cnt >= cnt1)
        {
            maxCnt = cnt;
        }
        else
        {
            maxCnt = cnt1;
        }
            Console.WriteLine(maxCnt);
    }
}

