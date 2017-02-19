using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static Sale ReadSale()
    {
        var input = Console.ReadLine()
            .Split(' ')
            .ToList();

        Sale sales = new Sale
        {
            Town = input[0],
            Product = input[1],
            Price = double.Parse(input[2]),
            Quantity = double.Parse(input[3])
        };
        return sales;
    }
    static void Main()
    {
        var listSales = new List<Sale>();
        int num = int.Parse(Console.ReadLine());
        for (int i = 0; i < num; i++)
        {
            Sale tempSale = ReadSale();
            listSales.Add(tempSale);
        }
        var result = new SortedDictionary<string, double>();
        foreach (var sale in listSales)
        {
            if (!result.ContainsKey(sale.Town))
            {
                result[sale.Town] = 0;
            }
            result[sale.Town] += sale.Price * sale.Quantity;
        }
        foreach (var kvp in result)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value:f2}");
        }

    }
}
