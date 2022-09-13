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
            
            while (true)

            {
                Console.WriteLine("Gissa ett tal mellan 1 och 100");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess > nummer)
                {
                    Console.Clear();
                    Console.WriteLine("Du gissade fel, talet är lägre");
                }
                else if (guess < nummer)
                {
                    Console.Clear();
                    Console.WriteLine("Du gissade fel, talet är högre");
                }
                else if (guess == nummer)
                {
                    Console.Clear();
                    Console.WriteLine("Du gissade rätt!");
                    break;
                    {



                    }
                }
 
            }
    }   }
}
