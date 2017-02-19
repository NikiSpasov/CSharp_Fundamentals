using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        List<string> phrases = new List<string>
            {
            "Excellent product.",
            "Such a great product.",
            "I always use that product.",
            "Best product of its category.",
            "Exceptional product.",
            "I can’t live without this product."
             };
        List<string> events = new List<string>
            {
            "Now I feel good.",
            "I have succeeded with this product.",
            "Makes miracles. I am happy of the results!",
            "I cannot believe but now I feel awesome.",
            "Try it yourself, I am very satisfied.",
            "I feel great!"
            };
        List<string> author = new List<string>
            {
            "Diana",
             "Petya",
             "Stella",
             "Elena",
             "Katya",
             "Iva",
             "Annie",
             "Eva"
            };
        List<string> cities = new List<string>
        {
            "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
        };

        Random phr = new Random();
        Random evn = new Random();
        Random autr = new Random();
        Random city = new Random();

        for (int i = 0; i < num; i++)
        {
            Console.WriteLine(
                phrases [phr.Next(0, phrases.Count - 1)] 
                + " " + events[evn.Next(0, events.Count - 1)] 
                + " " + author[autr.Next(0, author.Count - 1)]
                + " - " + cities[city.Next(0, cities.Count - 1)]);
        }
    }
}
