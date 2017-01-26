using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht8
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int numbers = 3; //kysyy kolme kertaa
            int greatest = 0;

            for (int i = 1; i <= numbers; i++)
            {
                Console.Write("Anna numero: ");
                string line = Console.ReadLine();
                bool result = Int32.TryParse(line, out number);
                if (result)
                {
                    if (i == 1) greatest = number;
                    else if (number > greatest) greatest = number;
                }
             
            }
            Console.WriteLine("Suurin luku on " + greatest);

        }
    }
}
