using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine()
            .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .ToList();
        var name = input[0];
        for (int i = 1; i < input.Count; i++)
        {
            
        } 

        ////string name = String.Empty;
        ////Dictionary<string, List<string>> namesAndCards = new Dictionary<string, List<string>>();

        ////while (true)
        ////{
        ////    name = Console.ReadLine();
        ////    if (name == "JOKER")
        ////    {
        ////        break;
        ////    }
        ////    var email = Console.ReadLine()
        ////        .ToLower()
        ////        .Split('.')
        ////        .ToList();



        ////    if (!(email[1] == "us" || email[1] == "uk"))
        ////    {
        ////        namesAndCards.Add(name, email);
        ////    }
        ////}
        ////foreach (var item in namesAndCards)
        ////{
        ////    Console.WriteLine($"{item.Key} -> " + item.Value[0]);
        ////}
    }
}

