using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht6
{
    class Program
    {
        static void Main(string[] args)
        {

            double kulutus = 7.02;
            double hinta = 1.595;

            // kysyy kilometrimäärän
            Console.WriteLine("Anna kilometri maara > ");
            double matka = double.Parse(Console.ReadLine());


                double bensa = matka / 100 * kulutus;
                double kustannus = bensa * hinta;
                Console.WriteLine("Bensaa kuluu " + bensa + " litraa");
                Console.WriteLine("Kustannus on " + kustannus + " euroa");
           
        }
    }
}
