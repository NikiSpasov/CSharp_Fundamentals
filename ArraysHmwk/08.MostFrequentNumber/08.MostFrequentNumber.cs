using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
            int cnt = 1;
            int max = 0;
            int mostFrq = 0;
            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = 1 + i; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        cnt++;
                        if (cnt > max)
                        {
                            max = cnt;
                            mostFrq = arr[i];
                        }
                    }
                    else
                    {
                        cnt = 1;
                    }
                }
            }
            Console.WriteLine(mostFrq);
        }
    }
}
