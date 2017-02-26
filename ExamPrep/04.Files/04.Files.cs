using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Programming_Fundamentals_Files
{
    class Program
    {

        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Regex r = new Regex(@"^(\w:|\w+)\\(?:.*\\\B|.*\\\b)?(.*);(\d+)$");

            Match matche;

            Dictionary<string, long> d = new Dictionary<string, long>();

            List<string> files = new List<string>();

            for (int i = 0; i < n; i++)

            {
                files.Add(Console.ReadLine());

            }

            Match q = Regex.Match(Console.ReadLine(), @"(\w+) \w+ (.*)");

            for (int i = 0; i < files.Count; i++)

            {
                matche = r.Match(files[i]);

                if (matche.Groups[1].Value == q.Groups[2].Value && matche.Groups[2].Value.EndsWith(q.Groups[1].Value))
                {
                    try
                    {
                        d.Add(matche.Groups[2].Value, long.Parse(matche.Groups[3].Value));
                    }
                    catch (ArgumentException)
                    {
                        d.Remove(matche.Groups[2].Value);
                        d.Add(matche.Groups[2].Value, long.Parse(matche.Groups[3].Value));
                    }
                }

            }

            if (d.Count == 0)
                Console.WriteLine("No");
            else

                foreach (KeyValuePair<string, long> kvp in d.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine("{0} - {1} KB", kvp.Key, kvp.Value);
                }
        }
    }
}