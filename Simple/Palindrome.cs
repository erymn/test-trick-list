Console.WriteLine("Palindrome Checker");
Console.Write("Masukkan String : ");
string input = Console.ReadLine();

char[] charArray = input.ToCharArray();
Array.Reverse(charArray);
string reverse = new string(charArray);

if (input == reverse) {
    Console.WriteLine("String is a Palindrome");
} else {
    Console.WriteLine("String is not a Palindrome");
}