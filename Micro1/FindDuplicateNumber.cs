int[] numbers = {1, 2, 2, 4, 5, 5, 5, 8, 9, 9, 10};

Console.WriteLine("Using LINQ Process - Advanced");
var duplicates = numbers.GroupBy(n => n)
    .Where(g => g.Count() > 1)
    .Select(s => s.Key);

foreach (var item in duplicates)
{
    Console.WriteLine(item);
}

Console.WriteLine("Using Hash");

var seen = new HashSet<int>();
var dup = new HashSet<int>();

foreach (var item in numbers)
{
    if (seen.Contains(item))
    {
        dup.Add(item);
    }
    else
    {
        seen.Add(item);
    }
}

foreach (var item in dup)
{
    Console.WriteLine(item);
}