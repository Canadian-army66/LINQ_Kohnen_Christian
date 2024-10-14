using System;
using System.Linq; //allows the code to use LINQ

namespace LINQ_Kohnen_Christian
{
    class Program
    {
        static void Main(string[] args)
        {
            Game[] games = new Game[]  //creates a Game array with a short list of games objects set to it
            {
                new Game("Minecraft", 'E', "Action-Adventure"),
                new Game("Titanfall", 'M', "Movement FPS"),
                new Game("Lies of P", 'M', "Action-Adventure"),
                new Game("Space Marine 2", 'M', "Thrisp Person Shooter"),
                new Game("I Love You Colonel Sanders", 'E', "Dating Sim")
            };
            var shortGames = from game in games  //makes a query that gets all the games with less than ot euqal to nine characters and upper cases them
                             where game.Title.Length <= 9
                             select $"Game Title: {game.Title.ToUpper()}";

            foreach(var game in shortGames)  //for each game in the variable, write it
            {
                Console.WriteLine(game);
            }

            var mineCraft = games.Where(game => game.Title == "Minecraft")  //makes a query method that finds the Minecraft game and assigns it to the mineCraft var
                .Select(game => $"Title: {game.Title}, ESRB: {game.Esrb}, Genre: {game.Genre}");  //makes it to if called, then print the facts about the game

            Console.WriteLine(mineCraft.FirstOrDefault());  //calls the first in the mineCraft var

            var eRated = from game in games  //makes a var that selects all E rated games
                         where game.Esrb == 'E'
                         select game.Title;

            Console.WriteLine("E rated games:");  //makes a title for the e rated games
            foreach(var game in eRated)  //for each e rated game in the variable, it prints it
            {
                Console.WriteLine($"{game}. ");
            }
            
            var mRatedAction = from game in games  //makes a var that selects all M rated games and Action games
                               where game.Esrb == 'M' && game.Genre.Contains("Action")
                               select game.Title;

            Console.WriteLine("M rated games:");  //makes a title for the m rated games
            foreach (var game in mRatedAction)  //for each m rated or action game in the variable, it prints it
            {
                Console.WriteLine(game);
            }
        }
    }
}