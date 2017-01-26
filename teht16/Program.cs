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
            // arpoo luvun
            Random random = new Random();
            int randomNumber = random.Next(100); 
            int luku;
            int guesses = 0;
            Console.WriteLine("Arvaa arvottu luku valilta 0-100");
            do
            {
                Console.Write("arvaa: "); //kysyy käyttäjältä lukua
                string line = Console.ReadLine();
                bool result = Int32.TryParse(line, out luku);
                if (result)
                {
                    if (luku < randomNumber) Console.WriteLine("Luku on suurempi");
                    else if (luku > randomNumber) Console.WriteLine("Luku on pienempi");
                    guesses++; //lisää jokaisen yrityksen jälkeen yhden arvaamisten määrään
                }
                
            } while (luku != randomNumber); // kun käyttäjä arvaa oikein
            Console.WriteLine("Oikean luvun arvaamiseen meni " + guesses + " arvausta!");
            Console.ReadLine();
        }
    }
}
