using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentKYH1
{
    internal class Game
    {
        public void Run()
        {

            Random random = new Random();
            bool restart = true;
            int guess;
            int nummer;
            int gissningar;
            string svar;
            Console.WriteLine("Gissa ett tal mellan 1 och 100.");
            while (restart)
            {
                guess = 0;
                gissningar = 0;
                nummer = random.Next(1, 100);
                svar = "";

                while (guess != nummer)
                {
                    try
                    {

                        guess = Convert.ToInt32(Console.ReadLine());

                        if (guess < nummer)
                            Console.WriteLine("Du gissade fel, talet är större");

                        else if (guess > nummer)
                            Console.WriteLine("Du gissade fel, talet är mindre");

                        gissningar++;
                    }
                    catch
                    {
                        Console.WriteLine("Du kan bara skriva ett tal med siffror. Försök igen!");
                    }
                }
                Console.WriteLine($"Rätt! Du gissade rätt på {gissningar} försök.");
                bool svarLoop = true;
                Console.WriteLine("Vill du spela igen (Ja/Nej)?");
                while (svarLoop)
                {
                    svar = Console.ReadLine();
                    if (svar == "Ja")
                    {
                        svarLoop = false;
                        restart = true;
                       
                    }
                    else if (svar == "Nej")
                    {
                        Console.WriteLine("Tack för den här gången!");
                        restart = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Du får bara svara med (Ja/Nej)");
                        svarLoop = true;
                    }
                }
            }
            
        }
    
}   }  
