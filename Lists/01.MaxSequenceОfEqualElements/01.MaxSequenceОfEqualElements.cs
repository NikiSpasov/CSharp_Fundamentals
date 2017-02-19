
namespace _01.MaxSequenceОfEqualElements
{
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

            for (int i = 0; i < myList.Count - 1; i++)
            {
                if (myList[i] == myList[i + 1])
                {
                    cnt++;
                    if (cnt > maxCnt)
                    {
                        mostFreq = myList[i];
                        maxCnt = cnt;
                    }   
                }
                else
                {
                    cnt = 1;
                }
            }
            List<int> maxNumbers = new List<int>();
            for (int i = 0; i < maxCnt; i++)
            {
                 maxNumbers.Add(mostFreq);
            }
            foreach (var number in maxNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}

