var nums = new[] { 1, 2, 3, 4 };
int size = 2;
for (int i = 0; i + size <= nums.Length; i++)
{
    Console.WriteLine(string.Join(" ", nums.Skip(i).Take(size)));
}
