int[] coins = { 1, 2, 5 };
int target = 5;
int[] dp = new int[target + 1];
dp[0] = 1;
foreach (int c in coins)
    for (int a = c; a <= target; a++)
        dp[a] += dp[a - c];
Console.WriteLine(dp[target]);
