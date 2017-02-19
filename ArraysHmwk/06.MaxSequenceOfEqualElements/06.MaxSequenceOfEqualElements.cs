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
        int tempIndex = 0;
        for (int i = 0; i < arr.Length -1; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                cnt++;
                if (cnt > temp)
                {
                    temp = cnt;
                    tempIndex = arr[i];
                }
            }
            else
            {
                cnt = 1;
            }
        }
        int[] RepetedElements = new int[temp];
        for(int i = 0; i < RepetedElements.Length; i++)
        {
            RepetedElements[i] = tempIndex;
        }
        Console.WriteLine(string.Join(" ", RepetedElements));
    }
}
