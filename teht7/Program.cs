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
            Console.WriteLine("anna vuosiluku"); // kysyy vuoden
            int vuosi = int.Parse(Console.ReadLine());
            
            if(vuosi % 4 == 0 && vuosi % 100 != 0 || vuosi % 400 == 0) // VUosi on neljällä jaettava, paiti täydet vuosisadat. Mutta 400 jaolliset on
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
