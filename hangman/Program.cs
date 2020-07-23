using System;
using hangmanLib;

namespace hangman
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            

            Player gracz = new Player();
            gracz.PlayerScore = 0;
            Console.WriteLine(gracz.PlayerScore);
            do
            {
                showMenu();
                string userChoose = Console.ReadLine();

                Int32.TryParse(userChoose, out int choose);

                switch (choose)
                {
                    case 1:
                        Game game = new Game();
                        string word = game.newGame();
                        char[] wordLetters = new char[word.Length];

                        for(int i = 0; i <= word.Length-1; i++)
                        {
                            wordLetters[i] = '_';
                        }

                        do
                        {
                            Console.WriteLine("Podaj literę: ");

                            string input = Console.ReadLine();
                            input = input.ToUpper();
                            char letter = input[0];

                            try
                            {
                                wordLetters = game.checkLetter(letter, word, wordLetters);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }

                            Console.WriteLine(wordLetters);

                            if(game.tryCounter == 5)
                            {
                                Console.WriteLine("\nPoprawna odpowiedź to: " + word);
                                Console.WriteLine("Koniec gry! Nie udalo Ci sie zgadnac slowa, sprobuj jeszcze raz :) \n");
                                break;
                            }

                            string wordLettersString = new string(wordLetters);
                            if(String.Compare(word, wordLettersString) == 0)
                            {
                                Console.WriteLine("\nBrawo! Udało Ci się odgadnąć :)");
                                gracz.PlayerScore++;
                                Console.WriteLine("Twój obecny wynik to " + gracz.PlayerScore + "\n\n");
                                break;
                            }

                        } while (true);

                        break;
                    case 2:
                        Console.WriteLine("Twój obecny wynik to " + gracz.PlayerScore);
                        break;
                    case 3:
                        Console.WriteLine("Żegnamy reklamy");
                        Environment.Exit(0);
                        break;
                }

            } while (true);
        }

        private static void showMenu()
        {
            Console.WriteLine("Witaj w grze wisielec! Twoim zadaniem jest zgadnąć słowo");
            Console.WriteLine("Wybierz co chcesz robić (wpisz cyfrę):");
            Console.WriteLine("1. Wylosuj słowo do ogadnęcia");
            Console.WriteLine("2. Pokaż mój wynik");
            Console.WriteLine("3. Wyjdz z gry");
        }
    }
}
