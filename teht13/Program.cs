using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pisteet = new int[5];

            for (int i = 0; i < pisteet.Length; i++) //kysyy pisteet
            {
                Console.Write("Anna pisteet: ");
                string line = Console.ReadLine();
                int piste;
                bool result = Int32.TryParse(line, out piste);
                if (result)
                {
                    pisteet[i] = piste;
                }
            }

            Array.Sort(pisteet); // järjestää suuruus järkkään
            int sum = pisteet[1] + pisteet[2] + pisteet[3]; //laskee summan keskimmisiltä jättää [0] ja [4] pois
            Console.WriteLine("Pisteiden summa on " + sum);
        }
    }
}
