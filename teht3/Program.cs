using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht3
{
    class Program
    {
        static void Main(string[] args)
        {
            // kysyy kolme lukua
            Console.Write("Anna luku > ");
            int luku1 = int.Parse(Console.ReadLine());

            Console.Write("Anna toinen luku > ");
            int luku2 = int.Parse(Console.ReadLine());

            Console.Write("Anna kolmas luku > ");
            int luku3 = int.Parse(Console.ReadLine());

           // laskee summan ja keksiarvon
            int summa = luku1 + luku2 + luku3;
            int keksiarvo = (luku1 + luku2 + luku3) / 3;

            Console.WriteLine("Lukujen summa on: " + summa);
            Console.WriteLine("Lukujen keskiarvo on: " + keksiarvo);
        }
    }
}
