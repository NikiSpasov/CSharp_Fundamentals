namespace _02.CommandInerpretter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<string> input =
                Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string command = Console.ReadLine();

            int start = 0;
            int count = 0;

            while (!command.Equals("end"))
            {
                string[] currentCommand = command.Split(' ');

                if (currentCommand[0].Equals("reverse"))
                {
                    bool bStart = int.TryParse(currentCommand[2], out start);
                    bool bCount = int.TryParse(currentCommand[4], out count);
                    if (bStart == false || bCount == false || start < 0 || count < 1 || start > input.Count - 1)
                    { 
                        Console.WriteLine("Invalid input parameters.");
                        command = Console.ReadLine();
                        continue;
                    }
                    List<string> tempForReverse = new List<string>();
                    for (int i = start; i < count + start; i++)
                    {
                        tempForReverse.Add(input[i]);
                    }
                    tempForReverse.Reverse();
                    input.RemoveRange(start, count);
                    input.InsertRange(start, tempForReverse);
                }
                else if (currentCommand[0].Equals("sort"))
                {
                    start = int.Parse(currentCommand[2]);
                    count = int.Parse(currentCommand[4]);
                    if (start < 0 || count < 1 || start > input.Count - 1)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        command = Console.ReadLine();
                        continue;
                    }
                    List<string> tempForSort = new List<string>();
                    for (int i = start; i < count + start; i++)
                    {
                        tempForSort.Add(input[i]);
                    }
                    tempForSort.Sort();
                    input.RemoveRange(start, count);
                    input.InsertRange(start, tempForSort);
                }
                else if (currentCommand[0].Equals("rollLeft"))
                {
                    count = int.Parse(currentCommand[1]);
                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        command = Console.ReadLine();
                        continue;
                    }
                    for (int i = 0; i < count; i++)
                    {
                        input.Add(input[0]);
                        input.RemoveAt(0);
                    }
                }
                else if (currentCommand[0].Equals("rollRight"))
                {
                    count = int.Parse(currentCommand[1]);
                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        command = Console.ReadLine();
                        continue;
                    }

                    for (int i = 0; i < count; i++)
                    {
                        input.Insert(0, input[input.Count - 1]);
                        input.RemoveAt(input.Count - 1);
                    }
                }
                command = Console.ReadLine(); 
            }
            Console.Write("[");
            Console.Write(string.Join(", ", input));
            Console.WriteLine("]");

        }
    }
}
