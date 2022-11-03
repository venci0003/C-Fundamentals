using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            int countTeams = int.Parse(Console.ReadLine());

            for (int i = 1; i <= countTeams; i++)
            {
                string[] teamInformation = Console.ReadLine().Split('-');

                string teamCreator = teamInformation[0];

                string teamName = teamInformation[1];

                if (teams.Any(team => team.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                if (teams.Any(team => team.TeamCreator == teamCreator))
                {
                    Console.WriteLine($"{teamCreator} cannot create another team!");
                    continue;
                }
                Team currentTeam = new Team(teamCreator, teamName);
                teams.Add(currentTeam);
                Console.WriteLine($"Team {teamName} has been created by {teamCreator}!");
            }

            string teamCommand = string.Empty;

            while ((teamCommand = Console.ReadLine()) != "end of assignment")
            {
                string[] memberInformation = teamCommand.Split("->").ToArray();

                string memberName = memberInformation[0];

                string teamToJoin = memberInformation[1];

                Team teamToJoinMember = teams.FirstOrDefault(team => team.TeamName == teamToJoin);

                if (teamToJoinMember == null)
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                    continue;
                }
                if (teams.Any(team => team.TeamMembers.Contains(memberName)))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamToJoin}!");
                    continue;
                }
                if (teams.Any(team => team.TeamCreator == memberName))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamToJoin}!");
                    continue;
                }
                teamToJoinMember.AddMembers(memberName);
            }

            List<Team> validTeams = teams
                .Where(team => team.TeamMembers.Count > 0)
                .OrderByDescending(team => team.TeamMembers.Count)
                .ThenBy(team => team.TeamName)
                .ToList();

            List<Team> disbandsTeams = teams
                .Where(team => team.TeamMembers.Count == 0)
                .OrderBy(team => team.TeamName)
                .ToList();

            PrintValidTeams(validTeams);

            Console.WriteLine("Teams to disband:");

            PrintDisbandsTeams(disbandsTeams);
        }

        static void PrintDisbandsTeams(List<Team> disbandsTeams)
        {
            foreach (Team invalidTeam in disbandsTeams)
            {
                Console.WriteLine($"{invalidTeam.TeamName}");
            }
        }

        static void PrintValidTeams(List<Team> validTeams)
        {
            foreach (Team team in validTeams)
            {
                Console.WriteLine($"{team.TeamName}");

                Console.WriteLine($"- {team.TeamCreator}");

                foreach (string member in team.TeamMembers.OrderBy(member => member))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
        }
    }
}
class Team
{
    public Team(string creator, string teamName)
    {
        this.TeamCreator = creator;
        this.TeamName = teamName;
        TeamMembers = new List<string>();
    }
    public string TeamCreator { get; set; }
    public string TeamName { get; set; }
    public List<string> TeamMembers { get; set; }
    public void AddMembers(string member)
    {
        this.TeamMembers.Add(member);
    }
}