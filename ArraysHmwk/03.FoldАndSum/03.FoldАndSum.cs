using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FoldАndSum
{
    class Program
    {
        private static int[] MakeTwoFoldedArraysFromOne(int[] arr)
        {
            int countIndexLeft = arr.Length / 4;
            int[] firstRow = new int[arr.Length / 2];
            for (int i = 0; i < firstRow.Length / 2; i++)
            {
                firstRow[i] = arr[countIndexLeft - 1 -i];
                firstRow[firstRow.Length - 1 - i] = arr[arr.Length - countIndexLeft +
                    i];
            }
            int[] secondRow = new int[arr.Length / 2];
            for (int i = 0; i < secondRow.Length; i++)
            {
                secondRow[i] = arr[countIndexLeft + i];
            }
            int[] summedArr = new int[arr.Length / 2];
            for (int i = 0; i < summedArr.Length; i++)
            {
                summedArr[i] = firstRow[i] + secondRow[i];
            }

            return summedArr;
        }
        private static int[] ReadNumbersFromConsoleAndMakeArray()
        {
            int[] myArr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            return myArr;
        }
        static void Main()
        {
            var a = MakeTwoFoldedArraysFromOne(ReadNumbersFromConsoleAndMakeArray());
            Console.WriteLine(string.Join(" ", a));
        }
    }
}
