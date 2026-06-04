int[] left = [1, 2, 3];
string[] right = ["a", "b"];

int n = Math.Max(left.Length, right.Length);
var parts = new List<string>(n);
for (int i = 0; i < n; i++)
{
    string a = i < left.Length ? left[i].ToString() : "-";
    string b = i < right.Length ? right[i] : "-";
    parts.Add(a + b);
}

Console.WriteLine(string.Join(" ", parts));
