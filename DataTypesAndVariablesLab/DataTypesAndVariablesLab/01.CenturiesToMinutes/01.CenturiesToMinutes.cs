using System;
class Program
{
    static void Main()
    {
        sbyte centuries = sbyte.Parse(Console.ReadLine());
        int years = centuries * 100;
        int days = (int)(years * 365.2422);
        int hours = days * 24;
        int minutes = hours * 60;
        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
    }
}
//a year has 365.2422 days at average 
//5 centuries = 500 years = 182621 days = 4382904 hours = 262974240 minutes
