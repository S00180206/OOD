using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise2;

namespace ManagingData
{
    class Program
    {
        static void Main(string[] args)
        {
            GameData db = new GameData();

            using (db)
            {
                ComputerGame g1 = new ComputerGame { GameID = 1, GameName = "FarCry", AgeRating = 15 };
                Character c1 = new Character() { CharacterID = 1, Name = "Sam", CharacterClass = "Stealth",GameID=1, ComputerGame = g1 };


                ComputerGame g2 = new ComputerGame { GameID = 2, GameName = "CallOfDuty", AgeRating = 18 };
                Character c2 = new Character() { CharacterID = 2, Name = "Rex", CharacterClass = "Gunslinger",GameID=2, ComputerGame = g2 };

                db.ComputerGames.Add(g1);
                db.ComputerGames.Add(g2);

                Console.WriteLine("Add ComputerGames to Database");

                db.Characters.Add(c1);
                db.Characters.Add(c2);

                Console.WriteLine("Add Characters to Database");

                db.SaveChanges();
                Console.WriteLine("Saved to Database");
            }
        }
    }
}
