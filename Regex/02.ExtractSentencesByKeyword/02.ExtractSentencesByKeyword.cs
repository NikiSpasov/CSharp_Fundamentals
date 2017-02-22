using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        var keyWord = Console.ReadLine();
        keyWord = " " + keyWord + " ";
        var text = Console.ReadLine()
            .Split(new char[] { '.', '!', '?' },
            StringSplitOptions.RemoveEmptyEntries);
        Regex regex = new Regex(keyWord);
        foreach (var item in text)
        {
            if (regex.IsMatch(item))
            {
                Console.WriteLine(item.Trim());
            }
        }
    }
}