int[] a = [-2, 1, -3, 4, -1, 2, 1, -5, 4];

int cur = a[0];
int best = a[0];
for (int i = 1; i < a.Length; i++)
{
    cur = Math.Max(cur + a[i], a[i]);
    best = Math.Max(best, cur);
}

Console.WriteLine(best);
