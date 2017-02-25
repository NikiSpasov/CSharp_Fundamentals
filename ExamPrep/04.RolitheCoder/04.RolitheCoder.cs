namespace _04.RolitheCoder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();               
            List<Event> events = new List<Event>();
            Regex regex = new Regex(@"(#|@)\w+");
            int i;
            bool correctRegex = true;
            Dictionary<string, string> idsNames = new Dictionary<string, string>();

            while (input != "Time for Code")
            {
                var data = input.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).ToList();
                Event currentEvent = new Event();
                for (i = 1; i < data.Count; i++)
                {
                    correctRegex = regex.IsMatch(data[i]);
                    if (correctRegex)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                if (correctRegex == false)
                {
                    input = Console.ReadLine();
                    continue;
                }
                currentEvent.Id = data[0];
                Regex regexForName = new Regex(@"(\w+)");
                var editedName = regexForName.Match(data[1]).ToString();
                currentEvent.Name = editedName;
                data.RemoveRange(0, 2);
                currentEvent.Participants = data;
                currentEvent.CountOfParticipants = data.Count;
                idsNames.Add(currentEvent.Id, currentEvent.Name);

                if (idsNames.ContainsKey(currentEvent.Id))

                {
                    if (idsNames[currentEvent.Id] == currentEvent.Name)
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                        
                    else
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                }
                else
                {
                    idsNames.Add(currentEvent.Id, currentEvent.Name);
                }
                events.Add(currentEvent);  
                //...........
                input = Console.ReadLine();
            }
            foreach (var eve in events.OrderByDescending(x => x.Participants.Count).ThenBy(y => y.Name))
            {
                Console.WriteLine($"{eve.Name} - {eve.CountOfParticipants}");
                foreach (var par in eve.Participants.OrderBy(x => x).Distinct())
                {
                    Console.WriteLine(par);
                }
            }
        }
    }
}
