using System;
using System.Collections.Generic;

Console.WriteLine("Count Character Frequency");
Console.Write("Masukkan String : ");
string input = Console.ReadLine();

Dictionary<char, int> charFrequency = new Dictionary<char, int>();
foreach (var item in input.ToCharArray())
{
    if(charFrequency.ContainsKey(item)){
        charFrequency[item]++;
    }else{
        charFrequency.Add(item, 1);
    }
}

foreach (var item in charFrequency)
{
    Console.WriteLine($"{item.Key} : {item.Value}");
}