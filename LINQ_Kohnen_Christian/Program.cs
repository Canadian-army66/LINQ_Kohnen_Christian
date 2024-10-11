using System;
using System.Linq;

namespace LINQ_Kohnen_Christian
{
    class Program
    {
        static void Main(string[] args)
        {
            Game[] games = new Game[]
            {
                new Game("Minecraft", 'E', "Action-Adventure"),
                new Game("Titanfall", 'M', "Movement FPS"),
                new Game("Lies of P", 'M', "Action-Adventure"),
                new Game("Space Marine 2", 'M', "Thrisp Person Shooter"),
                new Game("I Love You, Colonel Sanders!", 'E', "Dating Sim")
            };
            var shortGames = from game in games
                             where game.Title.Length < 9
                             select $"Game Title: {game.Title.ToUpper()}";

            foreach(var game in shortGames)
            {
                Console.WriteLine(game);
            }

            var mineCraft = games.Where(game => game.Title == "Minecraft")
                .Select(game => $"Title: {game.Title}, ESRB: {game.Esrb}, Genre: {game.Genre}");

            Console.WriteLine(mineCraft.FirstOrDefault());

            var eRated = from game in games
                         where game.Esrb == 'E'
                         select game.Esrb;

            Console.WriteLine("E rated games:");
            foreach(var game in eRated)
            {
                Console.Write(game);
            }       
        }
    }
}