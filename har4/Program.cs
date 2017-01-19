using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace har4
{
    class Program
    {
        static void Main(string[] args)
        {
            //kysyy iän
            Console.Write("Anna ikä > ");
            int ika = int.Parse(Console.ReadLine());

            if (ika < 18)
            {
                Console.WriteLine("alaikainen");
            }
            else if (ika >= 18 && ika <= 65) //mites?? 18-65, yläraja??
            {
                Console.WriteLine("Aikuinen");
            }
            else { 
                Console.WriteLine("Seniori");
            }
                    
                    
        }
    }
}
