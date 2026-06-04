int[] a = [5, 2, 8, 1, 9, 3];

for (int gap = a.Length / 2; gap > 0; gap /= 2)
{
    for (int i = gap; i < a.Length; i++)
    {
        int tmp = a[i];
        int j = i;
        while (j >= gap && a[j - gap] > tmp)
        {
            a[j] = a[j - gap];
            j -= gap;
        }
        a[j] = tmp;
    }
}

Console.WriteLine(string.Join(' ', a));
