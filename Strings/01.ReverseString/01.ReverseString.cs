
namespace _01.ReverseString
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main()
        {
            var reversed = Console.ReadLine().ToCharArray().Reverse();
            foreach (var item in reversed)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
