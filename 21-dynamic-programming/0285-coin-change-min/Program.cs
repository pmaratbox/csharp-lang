int[] coins = { 1, 2, 5 };
int amount = 11;
int[] dp = new int[amount + 1];
Array.Fill(dp, amount + 1);
dp[0] = 0;
for (int a = 1; a <= amount; a++)
    foreach (int c in coins)
        if (c <= a)
            dp[a] = Math.Min(dp[a], dp[a - c] + 1);
Console.WriteLine(dp[amount]);
