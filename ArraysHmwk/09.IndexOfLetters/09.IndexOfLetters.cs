using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alpha = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            char[] word = Console.ReadLine().ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                int numIndexOfAlpha = Array.IndexOf(alpha, word[i]);
                Console.WriteLine(word[i] + " -> " + numIndexOfAlpha);
            }
        }
    }
}
