namespace _01.HornetWings
{
    using System;
    class Program
    {
        static void Main()
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            decimal distanceInMetersFor1000Flaps = decimal.Parse(Console.ReadLine());
            int wingFlapsBeforeRest = int.Parse(Console.ReadLine());


            decimal metersTravelled = (wingFlaps / 1000) * distanceInMetersFor1000Flaps;
            
            int initialTime = wingFlaps / 100;
            int rests = (wingFlaps / wingFlapsBeforeRest) * 5;
            int secondsPassed = initialTime + rests;

            Console.WriteLine($"{metersTravelled:0.00} m.");
            Console.WriteLine($"{secondsPassed} s.");
        }
    }
}
