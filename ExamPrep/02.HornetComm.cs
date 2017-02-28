using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.HornetComm
{
    class Program
    {
        static void Main(string[] args)
        {
            int freqencyPrivate;
            string input = Console.ReadLine();
            Regex digitsOrLetters = new Regex(@"^[a-zA-Z0-9]+$");
            Regex anythingButDigits = new Regex(@"\D+");
            Regex letterAndOrDigits = new Regex(@"[A-Za-z0-9]+");
            List<string> privateMessages = new List<string>();
            List<string> broadcast = new List<string>();

            while (!input.Equals("Hornet is Green"))
            {
                var messeges = input
                    .Split(' ');
                bool isOnlyDigit = int.TryParse(messeges[0], out freqencyPrivate);
                bool digAndOrLet = digitsOrLetters.IsMatch(messeges[2]);

                bool anyButDig = anythingButDigits.IsMatch(messeges[0]);
                bool lettAndOrDigits = letterAndOrDigits.IsMatch(messeges[2]);

                if (isOnlyDigit && digAndOrLet)
                {
                    //private message
                    var reversed = messeges[0].Reverse().ToArray();
                    var resultFromReversed = new string(reversed);
                    string recepientMessage = messeges[2];
                    privateMessages.Add(resultFromReversed);
                    privateMessages.Add(recepientMessage);
                }
                else if (anyButDig && lettAndOrDigits)
                {
                    //broadcast
                    string broadcastMessage = messeges[0];
                    StringBuilder broadcastFrequency = new StringBuilder();

                    //make all caps small and all small caps in a string c#
                    //You must take the frequency and make all capital letters – small and all small letters – capital
                    char[] upperToSmallerAndOpposite = messeges[2].ToCharArray();
                    char tempChar = ' ';
                    foreach (var symbol in upperToSmallerAndOpposite)
                    {
                        if (char.IsUpper(symbol))
                        {
                            tempChar = char.ToLower(symbol);

                        }
                        else if (char.IsLower(symbol))
                        {
                            tempChar = char.ToUpper(symbol);
                        }
                        else
                        {
                            tempChar = symbol;
                        }
                        broadcastFrequency.Append(tempChar);
                    }

                    broadcast.Add(broadcastFrequency.ToString());
                    broadcast.Add(broadcastMessage);

                }
                else
                {
                    input = Console.ReadLine();
                    continue;
                }
                input = Console.ReadLine();
            }


            Console.WriteLine("Broadcasts:");
            if (broadcast.Count == 0)
            {
                Console.WriteLine("None");
            }
            for (int i = 0; i < broadcast.Count - 1; i+=2)
            {
                Console.WriteLine($"{broadcast[i]} -> {broadcast[i + 1]}");
            }

            Console.WriteLine("Messages:");
            if (privateMessages.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                for (int i = 0; i < privateMessages.Count - 1; i+=2)
                {
                    Console.WriteLine($"{privateMessages[i]} -> {privateMessages[i + 1]}");
                }
            }

        }
    }
}
