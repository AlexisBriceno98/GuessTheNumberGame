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

            Console.WriteLine("Gissa ett tal mellan 1 och 100");
            Random rand = new Random();
            int nummer = rand.Next(0, 100);
            int gissningar = 0;
            while (true)
                
            {
                try
                {
                    int guess = Convert.ToInt32(Console.ReadLine());

                    {

                    }
                    if (guess > nummer)
                    {
                        Console.WriteLine("Du gissade fel, talet är lägre");
                        gissningar++;
                    }
                    if (guess < nummer)
                    {
                        Console.Clear();
                        Console.WriteLine("Du gissade fel, talet är högre");
                        gissningar++;
                    }
                    else if (guess == nummer)
                    {
                        Console.Clear();
                        Console.WriteLine("Du gissade rätt!");
                        gissningar++;
                        Console.WriteLine($"Det tog dig {gissningar} gissningar");

                        Console.WriteLine("Vill du spela igen (Ja/Nej)?");
                        string svar = Console.ReadLine();
                        gissningar = 0;
                        if (svar == "Ja")
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Tack för den här gången!");
                            break;
                        }
                    }

                 }
                catch
                {
                    Console.WriteLine("Du kan bara skriva ett tal med siffror. Försök igen!");
                }
            }
        }
    
}   }  
