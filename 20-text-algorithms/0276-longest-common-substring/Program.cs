string a = "abcde";
string b = "xbcdy";

int[,] dp = new int[a.Length + 1, b.Length + 1];
int best = 0, end = 0;
for (int i = 1; i <= a.Length; i++)
{
    for (int j = 1; j <= b.Length; j++)
    {
        if (a[i - 1] == b[j - 1])
        {
            dp[i, j] = dp[i - 1, j - 1] + 1;
            if (dp[i, j] > best)
            {
                best = dp[i, j];
                end = i;
            }
        }
    }
}

Console.WriteLine(a.Substring(end - best, best));
