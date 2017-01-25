using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht9
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int summa = 0;
            bool result;
            do
            {
                Console.Write("anna luku: ");
                string line = Console.ReadLine();
                result = Int32.TryParse(line, out number);
                if (result)
                {
                    summa += number; //annettujen lukujen on summan lasku
                }
            }
            while (result && number != 0); // result ja number ei ole 0
            Console.WriteLine("annettujen lukujen summa on: " + summa);
        }
    }
}
