using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advance
{
    public class ArrayRotation
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int k = 4;
            int n = arr.Length;

            int[] result = new int[n];

            for (int i = 0; i < n; i++)
            {
                result[i] = arr[(i + k) % n];
            }

            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
        }
    }
}