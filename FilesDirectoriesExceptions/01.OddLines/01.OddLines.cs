using System;
using System.IO;

class Program
{
    static void Main()
    {
        var file = File.ReadAllLines("textOddLines.txt");

        for (int i = 1; i < file.Length; i+= 2)
        {
            if (i % 2 != 0)
            {
                File.AppendAllText("result.txt", file[i] + Environment.NewLine);
            }
        }
    }
}

