using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> myList = Console.ReadLine()
               .Split(' ')
               .Select(int.Parse)
               .ToList();

        int cnt = 1;
        int mostFreq = 0;
        int maxCnt = 0;
    }
}
