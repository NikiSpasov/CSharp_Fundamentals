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

        for (int i = 0; i < myList.Count; i++)
        {
            myList[i] = myList[i] + myList[i + 1];
            myList.RemoveAt(i + 1);
        }

        myList.ForEach(Console.WriteLine);
    }
}

