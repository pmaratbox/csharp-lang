(int w, int v)[] items = { (2, 3), (3, 4), (4, 5) };
int capacity = 5;
int[] dp = new int[capacity + 1];
foreach (var (w, v) in items)
    for (int c = capacity; c >= w; c--)
        dp[c] = Math.Max(dp[c], dp[c - w] + v);
Console.WriteLine(dp[capacity]);
