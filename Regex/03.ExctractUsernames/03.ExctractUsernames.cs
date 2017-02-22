using System;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        var text = Console.ReadLine()
            .Split(new char[] { '/', '\\', '(', ')', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int maxCnt = 0;
        string longestWord = string.Empty;
        foreach (var user in text)
        {
            int lenght = user.Length;
            if (lenght<maxCnt)
            {
                maxCnt = lenght;
                longestWord = user;
            }

        }
        Console.WriteLine(longestWord);

        
        //var matches = regex.Matches(text);
        //foreach (Match users in matches)
        //{
          //  Console.WriteLine(users);
        //}

    }
}
