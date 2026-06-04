int[] items = [1, 2, 3];

for (int mask = 0; mask < (1 << items.Length); mask++)
{
    List<int> subset = [];
    for (int i = 0; i < items.Length; i++)
    {
        if ((mask & (1 << i)) != 0)
        {
            subset.Add(items[i]);
        }
    }
    Console.WriteLine(subset.Count == 0 ? "{}" : string.Join(' ', subset));
}
