using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string[] fromInput = File.ReadAllLines("input.txt");
        for (int i = 0; i < fromInput.Length; i++)
        {
            File.AppendAllText("result.txt", (i+1).ToString() + ". " + fromInput[i] + Environment.NewLine);
        }
    }
}

