var parts = new List<string>();
int i = 1;
do
{
    parts.Add(i.ToString());
    i++;
} while (i <= 3);
Console.WriteLine(string.Join(" ", parts));
