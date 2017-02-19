using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    public static void ReadNumsReverseAnSum()
    {
        string[] myList = Console.ReadLine().Split();
        int sum = 0;

        for (int i = 0; i < myList.Length; i++)
        {
            string currennNum = myList[i];
            string reversedNum = string.Join("", currennNum.Reverse());
            int parsedNum = int.Parse(reversedNum);
            sum += parsedNum;
        }
        Console.WriteLine(sum); ;
       
    } 
    static void Main()
    {
       ReadNumsReverseAnSum();
        //one-liner:
        //Console.WriteLine(Console.ReadLine().Split().Select(x => int.Parse(string.Join("", x.Reverse()))).Sum());
    }
}


