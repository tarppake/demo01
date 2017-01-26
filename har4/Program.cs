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

            if (ika < 18) // jos alle 18 (<-17)
            {
                Console.WriteLine("alaikainen");
            }
            else if (ika >= 18 && ika <= 65) // jos 18 tai yli ja 65 tai alle sen
            {
                Console.WriteLine("Aikuinen");
            }
            else { //jos yli 65 (66->) 
                Console.WriteLine("Seniori");
            }
                    
                    
        }
    }
}
