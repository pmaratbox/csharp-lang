int[] nums = { 1, 3, 5, 7, 9 };
int target = 7;

int lo = 0, hi = nums.Length - 1, index = -1;
while (lo <= hi)
{
    int mid = (lo + hi) / 2;
    if (nums[mid] == target)
    {
        index = mid;
        break;
    }
    else if (nums[mid] < target)
    {
        lo = mid + 1;
    }
    else
    {
        hi = mid - 1;
    }
}

Console.WriteLine($"found {target} at index {index}");
