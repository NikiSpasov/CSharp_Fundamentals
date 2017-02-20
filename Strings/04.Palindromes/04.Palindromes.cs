using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        var text = Console.ReadLine()
        .Split(new char[] { ' ', '.', ',', '?', '!' },
        StringSplitOptions.RemoveEmptyEntries);
        StringBuilder palindromes = new StringBuilder();
        foreach (var word in text)
        {
            var input = word.ToCharArray();
            Array.Reverse(input);
            string output = new string(input);
            if (word.Equals(output))
            {
                palindromes.Append(word + " ");
            }
        }
        string[] fromPalindromes = 
            palindromes
            .ToString()
            .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        Console.WriteLine(string.Join(", ", fromPalindromes.Distinct().OrderBy(x => x)));
    }
}

