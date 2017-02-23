using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        var daysOfMarathon = int.Parse(Console.ReadLine());
        var numberOfRuners = int.Parse(Console.ReadLine());
        var avgLapsEveryRunnerMakes = int.Parse(Console.ReadLine());
        var trackLength = int.Parse(Console.ReadLine());
        var trackCapacity = int.Parse(Console.ReadLine());
        var moneyPerKilometer = double.Parse(Console.ReadLine());

        var totalRunners = 0;
        var totalRunnersPossible = trackCapacity * daysOfMarathon;
        if (numberOfRuners >= totalRunnersPossible)
        {
            totalRunners = totalRunnersPossible;
        }
        else
        {
            totalRunners = numberOfRuners;
        }

        ulong totalMeters = (ulong)(totalRunners * avgLapsEveryRunnerMakes * trackLength);
        ulong totalKilometers = totalMeters / 1000;
        decimal totalMoney = (totalKilometers * (decimal)moneyPerKilometer);
        Console.WriteLine($"Money raised: {totalMoney:0.00}");
    }
}
