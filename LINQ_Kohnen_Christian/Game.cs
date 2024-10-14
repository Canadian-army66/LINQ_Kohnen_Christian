using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Kohnen_Christian
{
    internal class Game
    {
        public string Title { get; }  //makes an automatic getter
        public char Esrb { get; }  //makes an automatic getter
        public string Genre { get; }  //makes an automatic getter

        public Game(string titleParam, char esrbParam, string genreParam) //creates a constructor that sets the title, esrb, and genre to a parameter
        {
            Title = titleParam;
            Esrb = esrbParam;
            Genre = genreParam;
        }
    }
}
