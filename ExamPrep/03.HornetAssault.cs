using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _03.Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ulong> beesReamining = new List<ulong>();

            ulong totalPower = 0;

            var beehives = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(ulong.Parse)
                .ToList();
            var hornetsPowers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(ulong.Parse)
                .ToList();

            foreach (var hornet in hornetsPowers)
            {
                totalPower += hornet;
            }

            foreach (var beehive in beehives)
            {
                if (totalPower > beehive)
                {
                    continue;
                }
                else if (totalPower <= beehive)
                {
                    beesReamining.Add(beehive - totalPower);
                    totalPower -= hornetsPowers[0];
                    hornetsPowers.RemoveAt(0);        
                }
            }
            ulong numOfBeesAlive = 0;
            foreach (var bee in beesReamining)
            {
                numOfBeesAlive += bee;
            }

            if (numOfBeesAlive > 0)
            {
                Console.WriteLine(string.Join(" ", beesReamining));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornetsPowers));
            }
               
        }
    }
}
