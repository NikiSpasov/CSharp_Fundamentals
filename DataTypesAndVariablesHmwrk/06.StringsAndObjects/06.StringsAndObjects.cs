using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();
            object twoWords = firstWord + " " + secondWord;
            string result = (string)twoWords;
            Console.WriteLine(result);
        }
    }
}
