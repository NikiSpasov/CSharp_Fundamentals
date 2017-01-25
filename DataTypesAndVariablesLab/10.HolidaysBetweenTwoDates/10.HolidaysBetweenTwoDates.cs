using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        string date1 = Console.ReadLine();
        string date2 = Console.ReadLine();
        DateTime startDate = DateTime.ParseExact(date1, "dd.mm.yyyy", CultureInfo.InvariantCulture);
        DateTime endDate = DateTime.ParseExact(date2, "dd.mm.yyyy", CultureInfo.InvariantCulture);
        int holidaysCount = 0;
        for (var date = startDate; date <= endDate; date.AddDays(1))
            if (date.DayOfWeek == DayOfWeek.Saturday &&
                date.DayOfWeek == DayOfWeek.Sunday) holidaysCount++;
        Console.WriteLine(holidaysCount);
    }
}


