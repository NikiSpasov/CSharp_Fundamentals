using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split(' ').ToArray();
        Dictionary<string, string> namesAndPhones = new Dictionary<string, string>();

        while (input[0] != "END")
        {
            var command = input[0];
            if (command == "A")
            {
                var name = input[1];
                var phone = input[2];
                if (namesAndPhones.ContainsKey(name))
                {
                    namesAndPhones.Remove(name);
                }
                namesAndPhones.Add(name, phone);
            }
            else if (command == "S")
            {
                var name = input[1];
                if (namesAndPhones.ContainsKey(name))
                {
                    var phone = namesAndPhones[name];
                    Console.WriteLine($"{name} -> {phone}");
                }
                else
                {
                    Console.WriteLine($"Contact {input[1]} does not exist.");
                }
            }
            input = Console.ReadLine().Split(' ').ToArray();
        }
    }       
}
