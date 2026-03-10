using System;
using System.Linq;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Angka besar kedua");
        Console.WriteLine("Masukkan angka (pisahkan spasi): ");
        string input = Console.ReadLine();

        int[] angka = input.Split(' ').Select(int.Parse).ToArray();
        Array.Sort(angka);

        int firstMax = angka[angka.Length - 1];
        int secMax = angka[angka.Length - 2];

        Console.WriteLine($"Max 1: {firstMax}");
        Console.WriteLine($"Max 2: {secMax}");
    }
}