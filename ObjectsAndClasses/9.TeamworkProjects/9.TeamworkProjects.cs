using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var teams = CreateTeams();
        while (true)
        {
            string[] input = Console.ReadLine()
                .Split( new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            
            if (input[0] == "end")
            {
                break;
            }
            foreach (var team in teams)
            {
                team.Members = new List<string>(); 
                if (input[1] == team.Name && !team.Members.Contains(input[0]))
                {
                    team.Members.Add(input[1]);
                }
                else if (!(team.Name == input[1]))
                {
                    Console.WriteLine($"Team {input[1]} does not exist!");
                }
                else
                {
                    Console.WriteLine($"Member {input[0]} cannot join team {input[1]}!");
                }
            }
        }


        foreach (var team in teams.OrderBy(x => x.Name).ThenByDescending(y => y.Members))
        {
            Console.WriteLine("- " + team.Creator);
            foreach (var teamMember in team.Members)
            {
                Console.WriteLine("-- " + team.Members);
            }
        }
        foreach (var team in teams.Where(x => x.Members.Count < 1).OrderBy(x => x.Name))
        {
            Console.WriteLine("Teams to disband: " + team.Name);
        }

    }


    private static List<Team> CreateTeams()
    {
        int teamsNum = int.Parse(Console.ReadLine());
        Dictionary<string, string> teamsAndCreators = new Dictionary<string, string>();
        List<Team> createdTeams = new List<Team>();
        for (int i = 0; i < teamsNum; i++)
        {
            Team currentTeam = new Team();
            string[] userAndTeam = Console.ReadLine().Split('-');
            currentTeam.Creator = userAndTeam[0];
            currentTeam.Name = userAndTeam[1];
            if (teamsAndCreators.ContainsKey(currentTeam.Creator))
            {
                Console.WriteLine($"{currentTeam.Creator} cannot create another team!");
                continue;
            }
            else if (teamsAndCreators.ContainsValue(currentTeam.Name))
            {
                Console.WriteLine($"Team {currentTeam.Name} was already created!");
                continue;
            }
            teamsAndCreators.Add(currentTeam.Creator, currentTeam.Name);
            Console.WriteLine($"Team {currentTeam.Name} has been created by {currentTeam.Creator}!");
            createdTeams.Add(currentTeam);

        }
        return createdTeams;
    }
}

