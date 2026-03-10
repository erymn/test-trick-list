using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advance
{
    public class ArrayEquilibrium
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 3, 5, 2, 2 };
            int total = 0, leftSum = 0;

            foreach (int item in arr)
            {
                total += item;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                total -= arr[i];

                if (leftSum == total)
                {
                    Console.WriteLine(i);   //harusnya yang diambil indexnya
                    return;
                }

                leftSum += arr[i];
            }

            Console.WriteLine("-1");
        }
    }
}