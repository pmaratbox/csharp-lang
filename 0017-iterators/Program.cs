int[] nums = { 1, 2, 3, 4, 5 };

int sum = nums
    .Where(n => n % 2 == 0)
    .Select(n => n * 2)
    .Sum();

Console.WriteLine($"sum: {sum}");
