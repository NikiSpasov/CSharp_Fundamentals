using System;
using System.Globalization;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        var startTime = Console.ReadLine();
        var steps = int.Parse(Console.ReadLine());
        var secondsForAStep = double.Parse(Console.ReadLine());
        BigInteger totalSeconds = steps * (int)secondsForAStep;
        DateTime start = DateTime.ParseExact(startTime, "HH:mm:ss", CultureInfo.InvariantCulture);
        DateTime end = start.AddSeconds((double)totalSeconds);
        Console.WriteLine("Time Arrival: {0:HH:mm:ss}", end);
    }
}


//80 ot 100
