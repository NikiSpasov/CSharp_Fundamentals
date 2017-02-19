using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
            int cnt = 1;
        int temp = 0;
        int startIndex = 0;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i + 1] > arr[i])
            {
                startIndex = i;
                cnt++;
                if (cnt > temp)
                {
                    temp = cnt;
                    int j = startIndex;    
                }
            }
            else
            {
                cnt = 1;
                //startIndex = i;
            }
        }

        //TO DO - Start index of the GrowingElements Array;
        int[] GrowingElements = new int[temp];
        for (int i = 0; i < temp; i++)
        {
            GrowingElements[i] = arr[startIndex + i];
        }
        Console.WriteLine(string.Join(" ", GrowingElements));
    }
}
