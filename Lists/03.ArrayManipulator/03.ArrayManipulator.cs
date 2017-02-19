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

        for (int k = 0; k >= 0; k++)
        {

            List<string> commands = Console.ReadLine()
            .Split(' ')
            .ToList();

            if (commands[0] == "add")
            {
                int index = int.Parse(commands[1]);
                int element = int.Parse(commands[2]);
                myList.Insert(index, element);
            }
            else if (commands[0] == "addMany")
            {
                int index = int.Parse(commands[1]);

                List<int> manyNums = new List<int>();
                for (int i = 2; i < commands.Count; i++)
                {
                    manyNums.Add(int.Parse(commands[i]));
                }

                myList.InsertRange(index, manyNums);
            }
            else if (commands[0] == "contains")
            {
                int element = int.Parse(commands[1]);
                bool isThere = myList.Contains(element);
                List<int> myBoolToNum = new List<int>();
                if (isThere)
                {
                    Console.WriteLine("0"); ;
                }
                else
                {
                    Console.WriteLine("-1");
                }
            }
            else if (commands[0] == "remove")
            {
                int index = int.Parse(commands[1]);
                myList.RemoveAt(index);
            }
            else if (commands[0] == "shift")
            {
                int positions = int.Parse(commands[1]);
                for (int i = 0; i < positions; i++)
                {
                    myList.Add(myList[0]);
                    myList.RemoveAt(0);
                }
            }
            else if (commands[0] == "sumPairs")
            {
                for (int i = 0; i < myList.Count / 2; i++)
                {
                    myList[i] = myList[i] + myList[i + 1];
                    myList.RemoveAt(i + 1);
                }
            }
            else if (commands[0] == "print")
            {
                break;
            }
        }

        Console.Write("[");
        Console.Write(string.Join(", ", myList));
        Console.WriteLine("]");
    }
}