int[] dims = { 10, 20, 30, 40 };
int n = dims.Length - 1;
int[,] dp = new int[n, n];
for (int len = 2; len <= n; len++)
    for (int i = 0; i + len - 1 < n; i++)
    {
        int j = i + len - 1;
        dp[i, j] = int.MaxValue;
        for (int k = i; k < j; k++)
        {
            int cost = dp[i, k] + dp[k + 1, j] + dims[i] * dims[k + 1] * dims[j + 1];
            dp[i, j] = Math.Min(dp[i, j], cost);
        }
    }
Console.WriteLine(dp[0, n - 1]);
