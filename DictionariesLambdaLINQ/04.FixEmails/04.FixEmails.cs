using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string person = String.Empty;
        Dictionary<string, List<string>> personAndEmail = new Dictionary<string, List<string>>(); 

        while (true)
        {
            person = Console.ReadLine();
            if (person == "stop")
            {
                break;
            }
            var email = Console.ReadLine()
                .ToLower()
                .Split('.')
                .ToList();
            if (!(email[1] == "us" || email[1] == "uk"))
            {
                personAndEmail.Add(person, email);
            } 
        }
        foreach (var item in personAndEmail)
        {
            Console.WriteLine($"{item.Key} -> " + item.Value[0] + "." + item.Value[1]);
        }
    }
}
