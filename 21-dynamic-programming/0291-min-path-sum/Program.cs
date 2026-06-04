int[][] grid = { new[] { 1, 3, 1 }, new[] { 1, 5, 1 }, new[] { 4, 2, 1 } };
int m = grid.Length, n = grid[0].Length;
int[,] dp = new int[m, n];
for (int i = 0; i < m; i++)
    for (int j = 0; j < n; j++)
    {
        int best = (i == 0 && j == 0) ? 0
            : Math.Min(i > 0 ? dp[i - 1, j] : int.MaxValue,
                       j > 0 ? dp[i, j - 1] : int.MaxValue);
        dp[i, j] = grid[i][j] + best;
    }
Console.WriteLine(dp[m - 1, n - 1]);
