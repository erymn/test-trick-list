using System;
using System.Text;

Console.WriteLine("Remove Duplicate");
Console.Write("Masukkan String : ");
string input = Console.ReadLine();

StringBuilder sb = new StringBuilder();

foreach(char c in input){
    if(!sb.ToString().Contains(c)){
        sb.Append(c);
    }
}

Console.WriteLine(sb.ToString());