using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arvosana = new int[6];
            int numero;
            bool result;
            Console.WriteLine("Syota opiskelijoiden arvosanat (0-5) enter lopettaa");

            do
            {
                Console.Write("Anna arvosana: ");
                string line = Console.ReadLine();
                result = Int32.TryParse(line, out numero);

                if (result)
                {
                    switch (numero)
                    {
                        case 0: arvosana[0]++; break;
                        case 1: arvosana[1]++; break;
                        case 2: arvosana[2]++; break;
                        case 3: arvosana[3]++; break;
                        case 4: arvosana[4]++; break;
                        case 5: arvosana[5]++; break;
                    }
                }
            }
            while (result); // tulostaa arvosana jakauman
            Console.WriteLine("arvosanat: ");
            
            for (int i = 0; i < arvosana.Length; i++)
            {
                Console.Write(i + ":");
                for (int k = 0; k < arvosana[i]; k++)
                    Console.Write("*");
                Console.WriteLine(); //että jokainen tulee omalle riville

            }
        }
    }
}
