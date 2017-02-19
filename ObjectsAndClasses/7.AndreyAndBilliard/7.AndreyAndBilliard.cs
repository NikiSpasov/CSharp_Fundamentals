using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<string, double> ItemsPrices = ReadItemsAndPrices(); 
        ReadClientsAndOrders(ItemsPrices);
    }

    private static void ReadClientsAndOrders(Dictionary<string, double> readItemsAndClients)
    {
        List<Customer> finalCustomers = new List<Customer>();
        while (true)
        {
            string[] order = Console.ReadLine()
                .Split(new char[] { '-', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (order[0] == "end")
            {
                break;
            }
            if (!readItemsAndClients.ContainsKey(order[1]))
            {
                continue;
            }
            Customer currentCustomer = new Customer();
            Dictionary<string, int> currDict = new Dictionary<string, int>();
            currDict.Add(order[1], int.Parse(order[2]));
            
            currentCustomer.Name = order[0];
            currentCustomer.ItemAndQuantity = currDict;
            finalCustomers.Add(currentCustomer);
        };

        foreach (var Customer in finalCustomers)
        {
            Console.WriteLine(Customer.Name + " " + Customer.ItemAndQuantity);
        }
    }

    private static Dictionary<string, double> ReadItemsAndPrices()
    {
        int num = int.Parse(Console.ReadLine());
        Dictionary<string, double> itemsAndPrices = new Dictionary<string, double>();
        for (int i = 0; i < num; i++)
        {
            string[] items = Console.ReadLine()
            .Split('-');
            if (itemsAndPrices.ContainsKey(items[0]))
            {
                itemsAndPrices[items[0]] = double.Parse(items[1]);
                continue;
            }
            itemsAndPrices.Add(items[0], double.Parse(items[1]));
        }
        return itemsAndPrices;
    }
}
