using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DayOfWeek
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrinyDayOfTheWeek(n);
        }

        private static void PrinyDayOfTheWeek(int n)
        {
            if (n < 1 || n > 7)
            {
                Console.WriteLine("Invalid day!");
                return;
            }
            else
            {
                string[] daysOfTheWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
                Console.WriteLine(daysOfTheWeek[n - 1]);
            }
        }
    }
}
