using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advance
{
    public class MissingNumber
    {
        public static void Main(string[] args)
        {
            int[] arr = { 3, 1, 4, 5 };
            int n = arr.Length + 1;

            // yang diharapkan
            int expected = n * (n + 1) / 2;
            int actual = 0;
            Console.WriteLine(expected);

            foreach (int x in arr)
            {
                actual += x;
            }
            Console.WriteLine(actual);
            Console.WriteLine(expected - actual);
        }
    }
}