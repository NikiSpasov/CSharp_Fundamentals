using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string resource = String.Empty;
        long quantity;
        Dictionary<string, long> fortune = new Dictionary<string, long>();

        while (true)
        {
            resource = Console.ReadLine();
            if (resource == "stop")
            {
                break;
            }
            quantity = long.Parse(Console.ReadLine());
            if (fortune.ContainsKey(resource))
            {
                quantity = fortune[resource] + quantity;
                fortune.Remove(resource);
            }
            fortune.Add(resource, quantity);
        }
        foreach (var item in fortune)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}

