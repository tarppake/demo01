using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Anna puun korkeus: ");
            string line = Console.ReadLine();
            bool result = Int32.TryParse(line, out numero);

            int puu = numero - 2;
            int kanta = numero - puu;

            if (result)
            {
                for (int i = 0; i < puu; i++)
                {
                    int spacesLenght = puu - i;
                    for (int space = 0; space <= spacesLenght; space++) //tulostaa välin
                    {
                        Console.Write(" ");
                    }
                    for (int star = 0; star <= i * 2; star++) // tulostaa tähden
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                for (int i = 0; i < kanta; i++) //kannan tulostus
                {
                    for (int space = 0; space <= puu; space++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("*");

                }
            }
        }
    }
}
