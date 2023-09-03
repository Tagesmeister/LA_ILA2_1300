using System.ComponentModel;

namespace LA_ILA2_1300
{
    internal partial class Program
    {
        class GameStart
        {
            Versuchen anzahlVersuchen = new Versuchen();
            Random ranObject = new Random();

            private int Input { get; set; }
            private int Number { get; set; }
            private bool Check { get; set; } = true;

            public GameStart(int number)
            {
                //Beginn des Spiels (Nummer generieren).
                RandomGenerator(number);
            }

            private void RandomGenerator(int number)
            {
                // Generiert eine zufällige Zahl.
                number = ranObject.Next(1, 101);

                //Speichert die mitgegebene Zahl vom Konstruktor (number) in die private Variabel (Number).
                Number = number;

                //Setzt AnzahlVersuch auf 0
                anzahlVersuchen.AnzahlVersuchen = 0;

                while (Check == true)
                {
                    // Leert die Console.
                    Console.Clear();

                    Eingabe();
                }
            }

            private void Eingabe()
            {
                Console.WriteLine("Geben Sie eine Zahl zwischen 1 und 100.");

                try
                {
                    Input = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();

                    //Überprüft ob der Input kleiner als 1 oder grösser als 100 ist.
                    if (Input < 1 || Input > 100)
                    {
                        throw new Exception();
                    }

                    Ueberpruefung();

                }
                catch
                {
                    Console.Clear();
                    Fehlerausgabe();
                }

            }

            private void Ueberpruefung()
            {
                // Gibt an ab Input zo gross oder klein ist.
                if (Input > Number)
                {
                    Console.WriteLine("Eingabe zu hoch");
                    Thread.Sleep(1200);

                    anzahlVersuchen.CountVersuchen();
                }
                else if (Input < Number)
                {
                    Console.WriteLine("Eingabe zu klein");
                    Thread.Sleep(1200);

                    anzahlVersuchen.CountVersuchen();

                }

                // Überprüft auf Überreinstimmung.
                if (Input == Number)
                {
                    Win();
                }
            }

            private void Win()
            {
                Console.WriteLine($"Richtig! Die gesuchte Zahl war: {Input}");
                Console.WriteLine($"Ihre Anzahl an Versuchen: {anzahlVersuchen.AnzahlVersuchen}");

                Console.WriteLine("(ENTER)");

                //Lässt ein Abstand.
                Console.ReadKey();

                Console.Clear();

                NewGame();
            }

            private void NewGame()
            {
                Console.WriteLine("Wollen Sie nochmal Spielen (y | n)");

                try
                {
                    string repeat = Console.ReadLine();

                    // Überprüft auf Fehlereingaben.
                    if (repeat != "y" && repeat != "n")
                    {
                        throw new Exception();
                    }

                    if (repeat == "y")
                    {
                        RandomGenerator(Number);
                    }

                    else if (repeat == "n")
                    {
                        Check = false;
                    }
                }
                catch
                {
                    Fehlerausgabe();
                }
            }

            private void Fehlerausgabe()
            {
                Console.Clear();

                Console.WriteLine("Ungültige Eingabe");

                Thread.Sleep(1200);
            }
        }
    }
}