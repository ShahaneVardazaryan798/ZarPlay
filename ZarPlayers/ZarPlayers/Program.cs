using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using static System.Console;

namespace ZarPlayers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int P1Money = 1000;
            int P2Money = 1000;
            WriteLine("Enter money");

            int Xaxadruyq = Convert.ToInt32(ReadLine());
            ForegroundColor = ConsoleColor.Green;
            WriteLine("The money is..." + Xaxadruyq);

            do
            {

                ForegroundColor = ConsoleColor.Yellow;
                WriteLine("ENTER YOUR ZAR");
                ReadLine();
            Start: int Zar1 = rd.Next(1, 7) + rd.Next(1, 7);
                WriteLine(Zar1);
                Thread.Sleep(1000);
                ForegroundColor = ConsoleColor.Yellow;
                WriteLine("NOW COMPUTER");
                Thread.Sleep(1000);
                int Zar2 = rd.Next(1, 7) + rd.Next(1, 7);
                WriteLine(Zar2);

                var rezult1 = (P1Money - ((Zar2 - Zar1) * Xaxadruyq));
                var rezult2 = (P2Money - ((Zar1 - Zar2) * Xaxadruyq));
                ReadLine();


                if (Zar1 > Zar2)
                {
                    WriteLine("Yor rezult is..." + rezult2);
                    WriteLine("The rezult of computer is..." + rezult1);
                    P2Money -= ((Zar1 - Zar2) * Xaxadruyq);
                    P1Money += ((Zar1 - Zar2) * Xaxadruyq);
                }
                else if (Zar1 == Zar2)
                {
                    goto Start;
                }
                else
                {
                    WriteLine("Yor rezult is..." + rezult1);
                    WriteLine("The rezult of computer is..." + rezult2);
                    P1Money -= ((Zar2 - Zar1) * Xaxadruyq);
                    P2Money += ((Zar2 - Zar1) * Xaxadruyq);
                }

                Thread.Sleep(2000);

            } while ((P1Money >= 0 && P1Money <= 100000) && (P2Money >= 0 && P2Money <= 100000));
            Thread.Sleep(2000);

            if (P1Money < 0 && P2Money < 0)
            {
                BackgroundColor = ConsoleColor.Red;
                Clear();
                SetCursorPosition(WindowHeight / 2, WindowWidth / 2);
                ForegroundColor = ConsoleColor.Yellow;
                WriteLine("YOU ARE THE BEST");
            }
            else
            {
                BackgroundColor = ConsoleColor.Green;
                Clear();
                SetCursorPosition(WindowHeight / 2, WindowWidth / 2);
                ForegroundColor = ConsoleColor.Magenta;
                WriteLine("YOU LOSE THE GAME");
            }
            ReadLine();

        }
    }
}
