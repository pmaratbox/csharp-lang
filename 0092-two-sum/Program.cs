var nums = new[] { 2, 7, 11, 15 };
int target = 9;
var seen = new Dictionary<int, int>();
for (int i = 0; i < nums.Length; i++)
{
    if (seen.TryGetValue(target - nums[i], out int j))
    {
        Console.WriteLine($"{j} {i}");
        break;
    }
    seen[nums[i]] = i;
}
