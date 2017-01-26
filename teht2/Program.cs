using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("anna pistemaara > "); //kysyy pistemäärän
            string line = Console.ReadLine();
            number = int.Parse(line);

            switch (number) //tulostaa pistemääärän mukaisen numeron
            {
                case 0:
                case 1: Console.WriteLine("Koulunumero on 0"); // 0 tai 1 > 0
                    break;
                case 2:
                case 3: Console.WriteLine("Koulunumero on 1"); // 2 tai 3 > 1
                    break;
                case 4:
                case 5: Console.WriteLine("Koulunumero on 2"); // 4 tai 5 > 2
                    break;
                case 6:
                case 7: Console.WriteLine("Koulunumero on 3"); // 6 tai 7 > 3
                    break;
                case 8:
                case 9: Console.WriteLine("Koulunumero on 4"); // 8 tai 9 > 4
                    break;
                case 10:
                case 11:
                case 12: Console.WriteLine("Koulunumero on 5"); // 10, 11 tai 12 > 5

                    break; 
            }
        }
    }
}
