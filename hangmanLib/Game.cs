using System;
using System.Collections.Generic;
using System.Text;

namespace hangmanLib
{
    public class Game
    {
        private List<string> words = new List<string>
            { "Zielony", "Niebieski" };
        public Game()
        {

        }

        public void newGame()
        {

        }

        public void showWordsLib()
        {
            foreach(string k in words)
            {
                Console.WriteLine(k);
            }
        }
    }
}
