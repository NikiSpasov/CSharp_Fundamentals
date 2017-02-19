using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
        string input = String.Empty;
        Dictionary<string, string> ipAndUser = new Dictionary<string, string>();
        int cnt = 1;

        while (!(input == "end"))
        {
            input = Console.ReadLine();
            string[] inputArr = input
                .ToString()
                .Split(new char[] { '=', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string ip = inputArr[1];
            string user = inputArr[5];

            if (ipAndUser.ContainsKey(ip))
            {
                cnt++;
            }
            ipAndUser.Add(ip, user);
        }
    }
}
