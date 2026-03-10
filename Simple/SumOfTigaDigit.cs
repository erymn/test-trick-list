Console.WriteLine("Sum of Three Digit Number");
Console.Write("Masukkan Angka : ");
string input = Console.ReadLine();

int number = int.Parse(input);
int sum = 0;

while (number > 0) {
    Console.WriteLine($"Number awal : {number}");

    int digit = number % 10;
    Console.WriteLine($"Digit : {digit}");

    sum += digit;
    Console.WriteLine($"Sum : {sum}");

    number /= 10;
    Console.WriteLine($"Number / 10: {number}");
}

Console.WriteLine("Sum of Three Digit Number : " + sum);