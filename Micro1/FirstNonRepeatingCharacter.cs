
Console.Write("Input : ");
string input = Console.ReadLine();

Console.WriteLine("Result using LINQ");
var firstNonRepeating = input.GroupBy(c => c)
    .Where(g => g.Count() == 1)
    .Select(s => s.Key)
    .FirstOrDefault();

Console.WriteLine($"First Non Repeating Character (Output) : {(firstNonRepeating == null ? "_" : firstNonRepeating)}");

Console.WriteLine("\nResult using For Loop");
var countChar = new Dictionary<char, int>();
foreach(var c in input){
    if(countChar.ContainsKey(c)){
        countChar[c]++;
    }else{
        countChar[c] = 1;
    }
}

foreach(var c in input){
    if(countChar[c] == 1){
        Console.WriteLine($"First Non Repeating Character (Output using For Loop) : {c}");
        break;
    }
}

