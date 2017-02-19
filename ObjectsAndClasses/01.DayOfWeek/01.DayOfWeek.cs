using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

class Program
{
    static void Main()
        
    {
        string input = Console.ReadLine();
        DateTime dayOfWeek = 
            DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine(dayOfWeek.DayOfWeek);
    }
}

