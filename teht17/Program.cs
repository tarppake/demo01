using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int[] array2 = { 5, 15, 25, 35, 45, 55, 65, 75, 85, 95 };
            int[] array3 = array1.Concat(array2).ToArray(); //yhdistää taulukot
            Array.Sort(array3); //järjestää luvut
            Console.WriteLine("luvut yhdistetyssä taulukossa:");
            for (int i = 0; i < array3.Length; i++)
            {
                Console.WriteLine(array3[i]); //tulostaa yhdistetyn taulukon
            }
            Console.ReadLine();
        }
    }
}
