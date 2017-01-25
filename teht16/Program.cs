using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht16
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(100);
            int luku;
            int guesses = 0;
            Console.WriteLine("Arvaa arvottu luku valilta 0-100");
            do
            {
                Console.Write("arvaa: ");
                string line = Console.ReadLine();
                bool result = Int32.TryParse(line, out luku);
                if (result)
                {
                    if (luku < randomNumber) Console.WriteLine("Luku on suurempi");
                    else if (luku > randomNumber) Console.WriteLine("Luku on pienempi");
                    guesses++;
                }
                
            } while (luku != randomNumber);
            Console.WriteLine("Oikean luvun arvaamiseen meni " + guesses + " arvausta!");
            Console.ReadLine();
        }
    }
}
