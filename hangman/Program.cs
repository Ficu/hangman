using System;
using hangmanLib;

namespace hangman
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Player gracz = new Player();

            do
            {
                showMenu();
                string userChoose = Console.ReadLine();

                Int32.TryParse(userChoose, out int choose);

                switch (choose)
                {
                    case 1:
                        Game game = new Game();
                        gracz.PlayerAttempts++;
                        string word = game.newGame();
                        char[] wordLetters = new char[word.Length];

                        for(int i = 0; i <= word.Length-1; i++)
                        {
                            wordLetters[i] = '_';
                        }
                        Console.WriteLine(wordLetters);
                        Console.WriteLine("\n\n");
                        do
                        {
                            Console.WriteLine("Podaj literę: ");
                            string input;
                            do
                            {
                                 input = Console.ReadLine();
                            } while (string.IsNullOrEmpty(input));
                            
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
                            Console.Write("\n");

                            if(game.tryCounter == 4)
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
                        Console.WriteLine("Odbyłeś już " + gracz.PlayerAttempts + " gier.");

                        break;
                    case 3:
                        Console.WriteLine("Koniec gry");
                        Console.WriteLine("Twój wynik to: " + gracz.PlayerScore);
                        Console.WriteLine("Ilosc twoich gier to: " + gracz.PlayerAttempts);
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
