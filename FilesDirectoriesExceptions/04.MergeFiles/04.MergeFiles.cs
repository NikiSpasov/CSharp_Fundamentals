

namespace _04.MergeFiles
{
    using System;
    using System.IO;

    class Program
    {
        static void Main()
        {
            string[] input1 = File.ReadAllLines("input1.txt");
            string[] input2 = File.ReadAllLines("input2.txt");

            for (int i = 0; i < input1.Length; i++)
            {
                File.AppendAllText("result.txt", input1[i] + Environment.NewLine);
                File.AppendAllText("result.txt", input2[i] + Environment.NewLine);
            }
        }
    }
}
