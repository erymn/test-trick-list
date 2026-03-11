using System.Globalization;
using System.Runtime.CompilerServices;

int[] nums = { 2, 7, 11, 15 };
int target = 9;

Console.WriteLine("Cara 1");
Console.WriteLine("----------------------------------");
TwoSum(nums, target);

Console.WriteLine();
Console.WriteLine("Cara 2 - Array Mechanism");
Console.WriteLine("----------------------------------");
TwoSumArrayMechanism(nums, target);

Console.WriteLine();
Console.WriteLine("Cara 3 - Using Dictionary");
Console.WriteLine("----------------------------------");
TwoSumUsingDictionary(nums, target);

void TwoSum(int[] numbers, int target)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        int compliment = target - numbers[i];
        if (numbers.Contains(compliment))
        {
            Console.WriteLine($"Output: [{i},{numbers.IndexOf(compliment)}]");
            return;
        }
    } 
    Console.WriteLine("Output: []");
}

void TwoSumArrayMechanism(int[] numbers, int target)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        for (int j = i +1 ;j < numbers.Length; j++)
        {
            if(numbers[i] + numbers[j] == target){    
                Console.WriteLine($"Output (Array Mechanism): [{i},{j}]");
                return;
            }
        }
    }    
    Console.WriteLine("Output (Array Mechanism): []");
}

void TwoSumUsingDictionary(int[] nums, int target)
{
    var map = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
        int compliment = target - nums[i];

        if (map.ContainsKey(compliment))
        {
            Console.WriteLine($"Output: [{map[compliment]}, {i}]");
            return;
        }

        map.Add(nums[i], i);
    }

}
