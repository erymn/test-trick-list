using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advance
{
    public class NegKArrayRotation
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int k = -3;

            int n = arr.Length;

            Console.WriteLine(k % n);
            //lakukan normalisasi dari k
            k = ((k % n) + n) % n;

            Console.WriteLine(k);

            int[] arrNew = new int[n];
            for (int i = 0; i < n; i++)
            {
                arrNew[i] = arr[(k + i) % n];
            }

            for (int i = 0; i < arrNew.Length; i++)
            {
                Console.Write(arrNew[i] + " ");
            }
        }
    }
}