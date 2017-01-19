using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna luku > ");
            int luku = int.Parse(Console.ReadLine());
            int tahdet = 1;
       
            for (int i = 0; i < luku; i++)
            { 
                for (int k = 0; k < tahdet; k++)
                {
                    Console.Write("*");
                }
                tahdet++;
                Console.WriteLine();
                

            }

        }
    }
}
