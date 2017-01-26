using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht5
{
    class Program
    {
        static void Main(string[] args)
        {
            //kysyy sekunnit
            Console.Write("Anna sekunnit > ");
            int sekunnit = int.Parse(Console.ReadLine());
           
                //laskee sekunneista tunnit, minuutit ja jäljelle jääneet sekunnit
                int tunnit = sekunnit / 3600; 
                int minuutit = sekunnit / 60 - tunnit * 60;
                int sekuntti = sekunnit % 60;

                // tulostaa vastauksen
                Console.WriteLine(tunnit + " tunti " + minuutit + " minuutti " + sekuntti  + " sekuntti"); 
            
                     
        }
    }
}
