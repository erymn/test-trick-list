using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Advance
{
    public class AnagramSample
    {
        public static void Main(string[] args)
        {
            bool isAnagram = true;

            Console.WriteLine("Cek Kata Anagram");
            Console.Write("Masukkan kata pertama: ");
            string input1 = Console.ReadLine();

            Console.Write("Masukkan kata kedua: ");
            string input2 = Console.ReadLine();

            //ANAGRAM
            //Pastikan length harus sama
            if (input1.Length != input2.Length)
            {
                isAnagram = false;
            }

            //Cek count character harus sama antara string1 dan string 2
            Dictionary<char, int> dictS1 = new Dictionary<char, int>();
            foreach (var item in input1.ToCharArray())
            {
                if (!dictS1.ContainsKey(item))
                {
                    dictS1.Add(item, 1);
                }
                else
                {
                    dictS1[item]++;
                }
            }

            Dictionary<char, int> dictS2 = new Dictionary<char, int>();
            foreach (var item in input2.ToCharArray())
            {
                //cek apakah di dictS1 mengandung salah satu karakter di input2?
                if (!dictS1.ContainsKey(item))
                {
                    isAnagram = false;
                }
                else
                {
                    dictS1[item]--;
                    if (dictS1[item] < 0)
                    {
                        isAnagram = false;
                    }
                }
            }

            if (isAnagram)
                Console.WriteLine($"Kata {input1} dan {input2} adalah ANAGRAM.");
            else
                Console.WriteLine($"Kata {input1} dan {input2} bukan ANAGRAM.");

        }

    }
}