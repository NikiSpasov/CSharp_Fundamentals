using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            var driversNames = Console.ReadLine()
                .Split(' ');

            var trackLayouts = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            var checkPointIndexes = Console.ReadLine()
              .Split(' ')
              .Select(int.Parse)
              .ToArray();

            foreach (var driver in driversNames)
            {
                var driverNameSplitted = driver.ToCharArray();
                double initialFuel = driverNameSplitted[0];
                for (int i = 0; i < trackLayouts.Length; i++)
                {
                    if (checkPointIndexes.Contains(i))
                    {
                        initialFuel += trackLayouts[i];
                    }
                    else
                    {
                        initialFuel -= trackLayouts[i];
                    }
                    if (initialFuel > 0)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"{driver} - reached {i}");
                        break;
                    }
                }
                if (initialFuel > 0)
                {
                    Console.WriteLine("{0} - fuel left {1:f2}", driver, initialFuel);
                }
            }

        }
    }
}
