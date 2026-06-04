string a = "ABCBDAB";
string b = "BDCAB";

int[,] dp = new int[a.Length + 1, b.Length + 1];
for (int i = 1; i <= a.Length; i++)
{
    for (int j = 1; j <= b.Length; j++)
    {
        dp[i, j] = a[i - 1] == b[j - 1]
            ? dp[i - 1, j - 1] + 1
            : Math.Max(dp[i - 1, j], dp[i, j - 1]);
    }
}

Console.WriteLine(dp[a.Length, b.Length]);
