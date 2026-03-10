using System;

Console.WriteLine("Check Prime Number");
Console.Write("Masukkan Angka : ");
string input = Console.ReadLine();

bool isPrime = true;

for (int i = 2; i <= int.Parse(input);i++){
    for (int y = 2; y < i; y++){
        if(i % y == 0){
            isPrime = false;
            break;
        }
    }
}

if(isPrime){
    Console.WriteLine("Prime Number");
}else{
    Console.WriteLine("Bukan Prime Number");
}
