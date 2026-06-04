int[] data = { 1, 2, 3, 4, 5 };
int n = data.Length;
var bit = new int[n + 1];

void Update(int i, int delta)
{
    for (i++; i <= n; i += i & -i) bit[i] += delta;
}

int Prefix(int count)
{
    int sum = 0;
    for (int i = count; i > 0; i -= i & -i) sum += bit[i];
    return sum;
}

for (int i = 0; i < n; i++) Update(i, data[i]);

Console.WriteLine(Prefix(4));
