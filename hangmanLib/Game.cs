using System;
using System.Collections.Generic;

namespace hangmanLib
{
    public class Game
    {
        private List<string> words = new List<string>
            { "OLA", "ALA", "ROWER", "TRAMWAJ", "WODA", "SOK", "SZAFA", "ANASTAZJOLOG", "ORTODONTA", "OKULISTA" };

        public List<char> askedChar = new List<char>();

        public int tryCounter { get; private set; }

        public Game()
        {

        }

        public string newGame()
        {
            var random = new Random();
            int index = random.Next(words.Count);

            return words[index];
        }

        public char[] checkLetter(Char letter, String word, char[] wordLetters)
        {
            List<int> letterIndex = new List<int>();

            if(askedChar.Contains(letter))
            {
                throw new Exception("Już próbowałeś tą literkę");
            } else
            {
                askedChar.Add(letter);
            }
                

            int startIndex = -1;

            while (true)
            {
                startIndex = word.IndexOf(letter, startIndex + 1, word.Length - startIndex - 1);

                if (startIndex < 0)
                    break;
                
                letterIndex.Add(startIndex);

            }


            if (letterIndex.Count == 0)
            {
                tryCounter++;
                throw new Exception("Pudło! : (");

            } else
            {
                foreach (int foundLetterIndex in letterIndex)
                {
                    wordLetters[foundLetterIndex] = letter;
                }
                return wordLetters;
            }

        }

    }
}
