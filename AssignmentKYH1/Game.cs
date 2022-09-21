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
            Console.WriteLine("Välkommen till Gissa ett tal!");
            Console.WriteLine("Gissa ett tal mellan 1 och 100");
            bool playAgain = true;
            Random rand = new Random();
            int nummer = rand.Next(1, 100);
            string svar = "";
            int gissningar = 0;
            
            while (playAgain)
 
            {
                gissningar++;
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess > nummer)
                {
                    Console.Clear();
                    Console.WriteLine("Du gissade fel, talet är lägre");
                }
                if (guess < nummer)
                {
                    Console.Clear();
                    Console.WriteLine("Du gissade fel, talet är högre");
                }
                else if (guess == nummer)
                {
                    Console.Clear();
                    Console.WriteLine($"Du gissade rätt! Det tog {gissningar} gissningar");

                    Console.WriteLine("Vill du spela igen? Y/N");
                    svar = Console.ReadLine();
                    if (svar == "Y")
                        playAgain = true;

                    else if (svar == "N")
                        playAgain = false;
                }

            }
        }
    }   
}
