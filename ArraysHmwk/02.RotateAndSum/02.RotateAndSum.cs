using System;
using System.Linq;

class Program
{
    private static int[] ReadNumbersFromConsoleAndMakeArray()
    {
        int[] myArr = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
        return myArr;
    }
    public static int[] ReverseLastPositionToFirstNTimes(int[] arr)
    {
        int Ntimes = int.Parse(Console.ReadLine());
        int[] reversed = new int[arr.Length];
        int[] summedArray = new int[arr.Length];

        for (int j = 0; j < Ntimes; j++)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                reversed[i + 1] = arr[i];
            }
            reversed[0] = arr[arr.Length - 1];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = reversed[i];
                summedArray[i] += arr[i];

            }
        }
        return summedArray;
    }
    static void Main()
    {
        int[] arr = ReadNumbersFromConsoleAndMakeArray();
        int[] reversed = ReverseLastPositionToFirstNTimes(arr);
        Console.WriteLine(string.Join(" ", reversed));
    }
}