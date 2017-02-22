using System;

class Program
{
    static void Main()
    {
        var driversNames = Console.ReadLine()
            .Split(' ');

        int[] trackLayout = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToIntArray();

        int[] checkPointIndexes = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToIntArray();
    }
}
