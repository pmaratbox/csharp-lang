var nums = new[] { 1, 2, 3, 4, 5, 6, 7 };
foreach (var chunk in nums.Chunk(3))
{
    Console.WriteLine(string.Join(" ", chunk));
}
