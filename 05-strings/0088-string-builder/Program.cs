var nums = new[] { 1, 2, 3 };
var sb = new System.Text.StringBuilder();
for (int i = 0; i < nums.Length; i++)
{
    if (i > 0) sb.Append("-");
    sb.Append(nums[i]);
}
Console.WriteLine(sb);
