using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {

        string[] bannedWords = 
            Console.ReadLine()
            .Split(new char[] { ' ', ','}, StringSplitOptions.RemoveEmptyEntries);

        string text = Console.ReadLine();
        foreach (var word in bannedWords)
        {
            if (text.IndexOf(word) >= 0)
            {
                text = text.Replace(word, (new string('*', word.Length)));
            }
        }
        Console.WriteLine(text);

    }
}

