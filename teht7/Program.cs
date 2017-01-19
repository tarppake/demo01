using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("anna vuosiluku");
            int vuosi = int.Parse(Console.ReadLine());
            
            if(vuosi % 4 == 0 && vuosi % 100 != 0 || vuosi % 400 == 0)
            {
                Console.WriteLine("Vuosi on karkausvuosi.");
            }

            else
            {
                Console.WriteLine("Vuosi ei ole karkausvuosi.");
            }

        }
    }
}
