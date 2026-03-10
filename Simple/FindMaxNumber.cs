using System;

Console.WriteLine("Find Max Number");
Console.Write("Masukkan Angka (pisahkan spasi) : ");
string input = Console.ReadLine();

string[] arrAngka = input.Split(' ');

int max = int.Parse(arrAngka[0]);
for (int i = 1; i < arrAngka.Length; i++) {
    int angka = int.Parse(arrAngka[i]);
    if (angka > max) {
        max = angka;
    }
}

Console.WriteLine("Max Number : " + max);