bool IsEven(int n)
{
    if (n == 0) return true;
    return IsOdd(n - 1);
}

bool IsOdd(int n)
{
    if (n == 0) return false;
    return IsEven(n - 1);
}

foreach (var n in new[] { 4, 3 })
{
    Console.WriteLine(IsEven(n) ? "even" : "odd");
}
