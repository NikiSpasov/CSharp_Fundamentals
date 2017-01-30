using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] myArr = new int[n];
        for (int i = 0; i < n; i++)
        {
            myArr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < myArr.Length / 2; i++)
        {
            int temp = myArr[i];
            myArr[i] = myArr[myArr.Length - 1 - i];
            myArr[myArr.Length - 1 - i] = temp;
        }
        Console.WriteLine(string.Join(" ", myArr));
    }
}