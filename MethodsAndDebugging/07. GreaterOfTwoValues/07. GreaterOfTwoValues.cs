using System;
class Program
{
    static void Main()
    {
        string dataType = Console.ReadLine();
        string firstEntry = Console.ReadLine();
        string secondEntry = Console.ReadLine();

        if (dataType == "int")
        {
            int firstNum = Convert.ToInt32(firstEntry);
            int secondNum = Convert.ToInt32(secondEntry);
            CompareInts(firstNum, secondNum);
        }
        else if (dataType == "char")
        {
            char firstChar = Convert.ToChar(firstEntry);
            char secondChar = Convert.ToChar(secondEntry);
            CompareChars(firstChar, secondChar);
        }
        else
        {
            CompareStrings(firstEntry, secondEntry);
        }
    }
    private static void CompareStrings(string firstString, string secondString)
    {
        if (firstString.CompareTo(secondString) >= 0)
        {
            Console.WriteLine(firstString);
        }
        else
        {
            Console.WriteLine(secondString);
        }
    }

    private static void CompareChars(char firstChar, char secondChar)
    {
        if (firstChar >= secondChar)
        {
            Console.WriteLine(firstChar);
        }
        else
        {
            Console.WriteLine(secondChar);
        }   
    }

    private static void CompareInts(int firstNum, int secondNum)
    {
        if (firstNum >= secondNum)
        {
            Console.WriteLine(firstNum);
        }
        else
        {
            Console.WriteLine(secondNum);
        }
    }
}
