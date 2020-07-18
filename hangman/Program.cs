using System;
using hangmanLib;

namespace hangman
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Game gra = new Game();

            Player gracz = new Player();
            gracz.PlayerScore = 0;
            Console.WriteLine(gracz.PlayerScore);
            int licznik = 0;
            do
            {
                showMenu();
                string userChoose = Console.ReadLine();

                Int32.TryParse(userChoose, out int choose);

                switch (choose)
                {
                    case 1:
                        gracz.PlayerScore++;
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
