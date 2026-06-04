int[] a = [5, 1, 4, 2, 8];

for (int i = 0; i < a.Length - 1; i++)
{
    for (int j = 0; j < a.Length - 1 - i; j++)
    {
        if (a[j] > a[j + 1])
        {
            (a[j], a[j + 1]) = (a[j + 1], a[j]);
        }
    }
}

Console.WriteLine(string.Join(' ', a));
