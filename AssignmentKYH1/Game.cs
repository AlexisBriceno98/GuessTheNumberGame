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

            Random rand = new Random();
            int nummer = rand.Next(0, 100);
            int gissningar = 0;
            while (true)
                
            {
                Console.WriteLine("Gissa ett tal mellan 1 och 100");
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
                    break;
                    {



                    }
                }
 
            }
    }   }
}
