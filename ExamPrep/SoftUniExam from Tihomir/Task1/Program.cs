using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Program
    {
        public static void Main()
        {
            var wingFlaps = int.Parse(Console.ReadLine());
            var distanceFor1000Flaps = double.Parse(Console.ReadLine());
            var endurance = int.Parse(Console.ReadLine());

            var distance = (wingFlaps / 1000) * distanceFor1000Flaps;
            Console.WriteLine($"{distance:f2} m.");

            var timeForFlaps = wingFlaps / 100;
            var timeRest = (wingFlaps / endurance) * 5;

            var totalTime = timeForFlaps + timeRest;
            Console.WriteLine(totalTime + " s.");

        }
    }
}
