﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OODLab8;
namespace DataManagment
{
    class Program
    {
        static void Main(string[] args)
        {
            TeamData db = new TeamData();

            using(db)
            {
                Team t1 = new Team() { TeamID = 1, TeamName = "Sligo Rovers", Location = "Sligo" };
                Player p1 = new Player() { PlayerID = 1, Name = "Tom", Position = "Forward", TeamID = 1, Team = t1 };
                Player p2 = new Player() { PlayerID = 2, Name = "Mick", Position = "Defender", TeamID = 1, Team = t1 };

                Team t2 = new Team() { TeamID = 2, TeamName = "Finn Harps", Location = "Donegal" };
                Player p3 = new Player() { PlayerID = 3, Name = "Sam", Position = "Midfielder", TeamID = 2, Team = t2 };
                Player p4 = new Player() { PlayerID = 4, Name = "Jim", Position = "Goalkeeper", TeamID = 2, Team = t2 };

                db.Teams.Add(t1);
                db.Teams.Add(t2);

                Console.WriteLine("Add teams to Database");

                db.Players.Add(p1);
                db.Players.Add(p2);
                db.Players.Add(p3);
                db.Players.Add(p4);

                Console.WriteLine("Add players to Database");

                db.SaveChanges();
                Console.WriteLine("Saved to Database");


            }
        }
    }
}
