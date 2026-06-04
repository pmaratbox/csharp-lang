int m = 3, n = 3;
int[,] dp = new int[m, n];
for (int i = 0; i < m; i++)
    for (int j = 0; j < n; j++)
        dp[i, j] = (i == 0 || j == 0) ? 1 : dp[i - 1, j] + dp[i, j - 1];
Console.WriteLine(dp[m - 1, n - 1]);
