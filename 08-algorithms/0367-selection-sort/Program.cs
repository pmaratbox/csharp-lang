int[] a = [5, 1, 4, 2];

for (int i = 0; i < a.Length - 1; i++)
{
    int min = i;
    for (int j = i + 1; j < a.Length; j++)
        if (a[j] < a[min]) min = j;
    (a[i], a[min]) = (a[min], a[i]);
}

Console.WriteLine(string.Join(' ', a));
