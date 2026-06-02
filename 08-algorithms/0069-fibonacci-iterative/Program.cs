int a = 0, b = 1;
var nums = new List<string>();
for (int i = 0; i < 7; i++)
{
    nums.Add(a.ToString());
    (a, b) = (b, a + b);
}
Console.WriteLine(string.Join(" ", nums));
