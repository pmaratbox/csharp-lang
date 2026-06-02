int[] asc = { 3, 1, 2 };
int[] desc = { 3, 1, 2 };
Array.Sort(asc);
Array.Sort(desc, (a, b) => b.CompareTo(a));
Console.WriteLine($"asc: {string.Join(" ", asc)}");
Console.WriteLine($"desc: {string.Join(" ", desc)}");
