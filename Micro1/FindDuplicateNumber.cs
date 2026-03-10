int[] numbers = {1, 2, 2, 4, 5, 5, 5, 8, 9, 10};

var duplicates = numbers.GroupBy(n => n)
    .Where(g => g.Count() > 1)
    .Select(s => s.Key);

foreach (var item in duplicates)
{
    Console.WriteLine(item);
}