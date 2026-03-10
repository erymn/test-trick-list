using System;

Console.WriteLine("Reverse Word Order");
Console.Write("Masukkan String : ");
string input = Console.ReadLine();

string[] words = input.Split(' ');
Array.Reverse(words);
string reverse = string.Join(" ", words);

Console.WriteLine(reverse);
