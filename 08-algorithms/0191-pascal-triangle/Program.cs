int rows = 4;
List<int> row = [1];

for (int r = 0; r < rows; r++)
{
    Console.WriteLine(string.Join(' ', row));
    List<int> next = [1];
    for (int i = 0; i < row.Count - 1; i++)
    {
        next.Add(row[i] + row[i + 1]);
    }
    next.Add(1);
    row = next;
}
