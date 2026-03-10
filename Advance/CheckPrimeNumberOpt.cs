using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advance
{
    public class CheckPrimeNumberOpt
    {
        public static void Main(string[] args)
        {
            bool isPrime = true;
            Console.Write("Cek apakah angka prima: ");
            int input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                isPrime = false;
                Console.WriteLine($"{input} bukan PRIMA");
                return;
            }

            if (input == 2)
            {
                isPrime = true;
                Console.WriteLine($"{input} adalah PRIMA");
                return;
            }

            if (input % 2 == 0)
            {
                isPrime = false;
                Console.WriteLine($"{input} bukan PRIMA");
                return;
            }

            for (int i = 3; i <= Math.Sqrt(input); i += 2)
            {
                if (input % i == 0)
                {
                    Console.WriteLine($"{input} bukan PRIMA");
                    break;
                }
            }

            Console.WriteLine($"{input} adalah PRIMA");
        }
    }
}