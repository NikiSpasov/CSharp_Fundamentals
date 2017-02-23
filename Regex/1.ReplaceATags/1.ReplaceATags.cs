using System;
using System.Text.RegularExpressions;


namespace _1.ReplaceATags
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            while (text != "end")
            {
                var regex = new Regex(@"<a.*href=(""|')(.*)\1>(.*?)<\/a>");
                var matches = regex.Matches(text);
                var result = regex.Replace(text, @"[URL href=""$2""]$3[/URL]");
                Console.WriteLine(result);
                text = Console.ReadLine();
            }
        }
    }
}
