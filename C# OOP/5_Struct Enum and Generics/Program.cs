﻿// See https://aka.ms/new-console-template for more information
namespace StructExample
{
    internal class Program
    {
        static void main(string[] args)
        {
           Console.WriteLine("Hello, World!");
           FootballTeam Team1 = new FootballTeam();
           Team1.Name = "Team1";
           Team1.Win = 2;
           Team1.Draw = 1;
           Team1.Lose = 0;
           FootballTeam Team2 = new FootballTeam();
           Team2.Name = "Team2";
           Team2.Win = 1;
           Team2.Draw = 1;
           Team2.Lose = 1;
           FootballTeam Team3 = new FootballTeam();
           Team3.Name = "Team3";
           Team3.Win = 0;
           Team3.Draw = 1;
           Team3.Lose = 2;

           List<FootballTeam> MyList = new List<FootballTeam>();
            MyList.Add(Team1);
            MyList.Add(Team2);
            MyList.Add(Team3);

            int MostWins = 0;
            foreach (FootballTeam team in MyList)
            {
                if (team.Win > MostWins)
                {
                    MostWins = team.Win;
                }
            }
            Console.WriteLine($"Most Wins: {MostWins}");
        }
    }
}   