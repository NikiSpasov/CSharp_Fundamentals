

namespace _01.SoftuniCoffeeOrders
{
    using System;
    using System.Globalization;

    class Program
    {
        static void Main()
        {
            int numOfOrders = int.Parse(Console.ReadLine());
            decimal totalPrice = 0.0m;
            decimal pricePerCapsule = 0m;
            int capsulesCount = 0;
            decimal pricePerDay = 0m;
            DateTime orderDate = new DateTime();
            decimal tempTotal = 0m;
            int daysInMonth = 0;

            for (int i = 0; i < numOfOrders; i++)
            {
                pricePerCapsule = decimal.Parse(Console.ReadLine());
                orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                capsulesCount = int.Parse(Console.ReadLine());
                pricePerDay = pricePerCapsule * capsulesCount;
                daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
                tempTotal = pricePerDay * daysInMonth;
                totalPrice += tempTotal;
                Console.WriteLine($"The price for the coffee is: ${tempTotal:0.00}");
            }
            Console.WriteLine($"Total: ${totalPrice:0.00}");

        }
    }
}
