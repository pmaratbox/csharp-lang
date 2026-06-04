static bool IsPerfect(int n)
{
    int sum = 0;
    for (int d = 1; d < n; d++)
        if (n % d == 0) sum += d;
    return sum == n;
}

Console.WriteLine($"{(IsPerfect(6) ? "yes" : "no")} {(IsPerfect(8) ? "yes" : "no")}");
