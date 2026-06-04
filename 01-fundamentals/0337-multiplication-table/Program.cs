for (int i = 1; i <= 3; i++)
{
    var row = Enumerable.Range(1, 3).Select(j => i * j);
    Console.WriteLine(string.Join(' ', row));
}
