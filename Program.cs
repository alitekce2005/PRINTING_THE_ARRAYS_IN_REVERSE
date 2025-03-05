using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme_odası_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int[] dizi = { 1, 2, 3, 4, 5 };
                int tut;

                // Orjinal diziyi yazdırma
                Console.WriteLine("Orjinal hali");
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("{0} ", dizi[i]);
                }

                // Diziyi tersine çevirme
                Console.WriteLine("\nTers hali");
                for (int i = 0; i < 3; i++)
                {
                    tut = dizi[i];
                    dizi[i] = dizi[5 - i - 1];
                    dizi[5 - i - 1] = tut;
                }

                for (int i = 0; i < 5; i++)
                {
                    Console.Write("{0} ", dizi[i]);
                }
            
        }

    }
}
