using System;
using System.Text.RegularExpressions;



class Program
{
    static void Main()
    {
        var text = Console.ReadLine();
        var regex = new Regex (@"(?<=\s|^)([a-z0-9]+(?:[_.-][a-z0-9]+)*@(?:[a-z]+\-?[a-z]+\.)+[a-z]+\-?[a-z]+)\b");
        var matches = regex.Matches(text);
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Groups[0]);
        }

    }
}
