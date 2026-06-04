int[] nums = { 3, 34, 4, 12, 5, 2 };
int target = 9;
bool[] dp = new bool[target + 1];
dp[0] = true;
foreach (int x in nums)
    for (int s = target; s >= x; s--)
        dp[s] = dp[s] || dp[s - x];
Console.WriteLine(dp[target] ? "yes" : "no");
