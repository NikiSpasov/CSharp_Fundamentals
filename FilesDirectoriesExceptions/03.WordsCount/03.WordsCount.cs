using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] words = File.ReadAllText("words.txt").ToLower().Split(' ');
        string[] text = File.ReadAllText("text.txt").ToLower()
            .Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' },
            StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        foreach (string word in words)
        {
            wordCount[word] = 0;
        }
        foreach (string word in text)
        {
            if (wordCount.ContainsKey(word))

            {
                wordCount[word]++;
            }
        }
        foreach (KeyValuePair<string, int> word in wordCount.OrderByDescending(key => key.Value))
        {
            File.AppendAllText("result.txt", $"{word.Key} - {word.Value}" + Environment.NewLine);
        }
        string[] finalResult = File.ReadAllLines("result.txt");
        foreach (var result in finalResult)
        {
            Console.WriteLine(result);
        }
        File.Delete("result.txt");
    }
}