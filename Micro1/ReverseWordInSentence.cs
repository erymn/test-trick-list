string str = "dotnet is awesome";

var result = str.Split(' ').Reverse();

Console.WriteLine(string.Join(" ", result));

Console.Write("Masukkan kalimat yang mau dibalik: ");
string strKal = Console.ReadLine();
Console.WriteLine(ReverseWordFromAString(strKal));

string ReverseWordFromAString(string oriWord)
{
    return string.Join(' ', oriWord.Split(' ').Reverse());
}