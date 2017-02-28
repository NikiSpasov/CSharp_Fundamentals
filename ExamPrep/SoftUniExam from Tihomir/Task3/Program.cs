using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main()
        {
            var beehives = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
            var hornets = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToList();

            var aliveBehives = new List<BigInteger>();

            var power = hornets.Aggregate(BigInteger.Add);
            var count = 0;

            for (int i = 0; i < beehives.Length; i++)
            {

                if (power <= beehives[i])
                {
                    if (power < beehives[i])
                    {
                        aliveBehives.Add(beehives[i] - power);
                    }
                    power = power - hornets[count];
                    hornets.RemoveAt(count);
                }
            }

            if (aliveBehives.Count > 0)
            {
                Console.WriteLine(string.Join(" ", aliveBehives));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
