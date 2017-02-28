using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task2
{
    public class Program
    {
        public static void Main()
        {
            var messagesRecipient = new List<string>();
            var messages = new List<string>();
            var broadcastFrequency = new List<string>();
            var broadcastMessages = new List<string>();


            while (true)
            {
                var inputInitial = Console.ReadLine();

                if (inputInitial == "Hornet is Green")
                {
                    break;
                }
                var input = inputInitial
                    .Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(p => p.Trim())
                    .ToArray();



                var regex = new Regex("^[0-9]+$");
                var match = regex.Match(input[0]);
                if (match.Success)
                {
                    var regexMessage = new Regex("^[0-9A-Za-z]+$");
                    var matchMessage = regexMessage.Match(input[1]);

                    if (matchMessage.Success)
                    {
                        messages.Add(input[1]);
                    }
                    else
                    {
                        continue;
                    }
                    var reverse = Reverse(input[0]);
                    messagesRecipient.Add(reverse);
                }
                else
                {
                    var frequency = input[1];
                    var str = new char[frequency.Length];

                    var regexBroadcast = new Regex("^[0-9A-Za-z]+$");
                    var matchBroadcast = regexBroadcast.Match(input[1]);
                    if (matchBroadcast.Success)
                    {
                        for (int i = 0; i < frequency.Length; i++)
                        {
                            if (frequency[i] >= 'A' && frequency[i] <= 'Z')
                            {
                                str[i] = Char.ToLower(frequency[i]);

                            }
                            else if (frequency[i] >= 'a' && frequency[i] <= 'z')
                            {
                                str[i] = Char.ToUpper(frequency[i]);
                            }
                            else
                            {
                                str[i] = frequency[i];
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }

                    var frequencyString = new string(str);

                    broadcastFrequency.Add(frequencyString);
                    broadcastMessages.Add(input[0]);
                }
            }

            Console.WriteLine("Broadcasts:");
            if (broadcastFrequency.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                for (int i = 0; i < broadcastFrequency.Count; i++)
                {
                    Console.Write($"{broadcastFrequency[i]} -> ");
                    Console.WriteLine($"{broadcastMessages[i]}");
                }
            }

            Console.WriteLine("Messages:");
            if (messagesRecipient.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                for (int i = 0; i < messagesRecipient.Count; i++)
                {
                    Console.Write($"{messagesRecipient[i]} -> ");
                    Console.WriteLine($"{messages[i]}");
                }
            }
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
