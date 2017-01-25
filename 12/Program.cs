using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luvut = new int[5];

            for (int i = 0; i < 5; i++); //kysyy luvut
            {
                Console.Write("Anna luku: ");
                string line = Console.ReadLine();
                int luku;
                bool result = Int32.TryParse(line, out luku);
                if (result)
                {
                    luvut[i] = luku; //??  
                }
            }
            Console.Write("luvut ovat: ");
            for (int i = luvut.Length - 1; i >= 0; i--)
            {
                Console.Write(luvut[i]);
                if (i > 0) Console.Write(" , ");
                    
            }
        }
    }
}
