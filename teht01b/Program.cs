using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht01b
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask a number
            int number;
            Console.Write("Give a number >");
            string line = Console.ReadLine(); // "1"
            bool result = int.TryParse(line, out number);
            if (result == true)
            {
                // which number...
                switch (number)
                {
                    case 1: Console.WriteLine("yksi"); break;
                    case 2: Console.WriteLine("kaksi"); break;
                    case 3: Console.WriteLine("kolme"); break;
                    default: Console.WriteLine("joku muu luku"); break;
                }
         
            }else
            {
                Console.WriteLine("Not a integer valua!");
            } 
                 
            // wait enter...
            Console.ReadLine();
        }
    }
}
