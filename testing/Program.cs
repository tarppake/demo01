using System;

namespace T10
{
    /// <summary> 
    /// This class displays word "HEP" when there is a even number in given array.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 33, 44, 55, 68, 77, 96, 100 };
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0) Console.WriteLine("HEP! in position {0} and number was {1}.", i, array[i]);
            }
            Console.ReadLine();
        }
    }
}