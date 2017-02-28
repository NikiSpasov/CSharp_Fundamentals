using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex digitsOrLetters = new Regex(@"^[a-zA-Z0-9]+$");
            bool isTRue = digitsOrLetters.IsMatch("Pr1v@teM3ssage");
            Console.WriteLine(isTRue);

        }
    }
}
