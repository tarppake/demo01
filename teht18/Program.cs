using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht18
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kysyy tekstiä
            Console.Write("Syota tekstia: ");
            string line = Console.ReadLine();
            int length = line.Length;
            bool palindromi = true;
            for (int i = 0; i < length / 2; i++)
            {
               
                if (line[i] != line[length - i - 1])
                {
                    palindromi = false;
                    break;
                }
            }
            if (palindromi) Console.WriteLine("annettu teksti on palindromi");
            else Console.WriteLine("annettu teksti ei ole palindromi");
        }
    }
}
