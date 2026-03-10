internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Reverse String from TestTrick");
        Console.Write("Masukkan String : ");
        string input = Console.ReadLine();

        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string reverse = new string(charArray);

        Console.WriteLine("String Reverse : " + reverse);
    }
}