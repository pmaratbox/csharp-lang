int[] nums = { 1, 5, 11, 5 };
int total = nums.Sum();
if (total % 2 != 0)
{
    Console.WriteLine("no");
    return;
}
int target = total / 2;
bool[] dp = new bool[target + 1];
dp[0] = true;
foreach (int x in nums)
    for (int s = target; s >= x; s--)
        dp[s] = dp[s] || dp[s - x];
Console.WriteLine(dp[target] ? "yes" : "no");
