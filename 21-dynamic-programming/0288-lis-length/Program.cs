int[] nums = { 10, 9, 2, 5, 3, 7, 101, 18 };
int[] dp = new int[nums.Length];
Array.Fill(dp, 1);
int best = 0;
for (int i = 0; i < nums.Length; i++)
{
    for (int j = 0; j < i; j++)
        if (nums[j] < nums[i])
            dp[i] = Math.Max(dp[i], dp[j] + 1);
    best = Math.Max(best, dp[i]);
}
Console.WriteLine(best);
