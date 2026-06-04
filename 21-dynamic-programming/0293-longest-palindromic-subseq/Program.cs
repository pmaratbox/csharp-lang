string s = "bbbab";
int n = s.Length;
int[,] dp = new int[n, n];
for (int i = n - 1; i >= 0; i--)
{
    dp[i, i] = 1;
    for (int j = i + 1; j < n; j++)
        dp[i, j] = s[i] == s[j]
            ? dp[i + 1, j - 1] + 2
            : Math.Max(dp[i + 1, j], dp[i, j - 1]);
}
Console.WriteLine(dp[0, n - 1]);
