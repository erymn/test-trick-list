using System;

Console.WriteLine("FizzBuzz Application");
Console.Write("Masukkan Angka (pisahkan spasi) : ");
string input = Console.ReadLine();

string[] arrAngka = input.Split(' ');

for (int i = 0; i < arrAngka.Length; i++) {
    int angka = int.Parse(arrAngka[i]);
    if (angka % 3 == 0 && angka % 5 == 0) {
        Console.Write("FizzBuzz ");
    } else if (angka % 3 == 0) {
        Console.Write("Fizz ");
    } else if (angka % 5 == 0) {
        Console.Write("Buzz ");
    } else {
        Console.Write(angka + " ");
    }
}

