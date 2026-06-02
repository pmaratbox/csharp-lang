int[,] a = { { 1, 2 }, { 3, 4 } };
int[,] b = { { 5, 6 }, { 7, 8 } };
int n = 2;
int[,] result = new int[n, n];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        for (int k = 0; k < n; k++)
        {
            result[i, j] += a[i, k] * b[k, j];
        }
    }
}

for (int i = 0; i < n; i++)
{
    var parts = new List<string>();
    for (int j = 0; j < n; j++)
    {
        parts.Add(result[i, j].ToString());
    }
    Console.WriteLine(string.Join(" ", parts));
}
