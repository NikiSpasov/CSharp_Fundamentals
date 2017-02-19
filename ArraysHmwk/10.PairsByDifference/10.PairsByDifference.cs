using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int diff = int.Parse(Console.ReadLine());
        int cnt = 0;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 1 + i; j < arr.Length; j++)
            {
                int absolute = Math.Abs(arr[i] - arr[j]);
                if (absolute == diff)
                {
                    cnt++;
                }
            }
        }
        Console.WriteLine(cnt);
    }
}
