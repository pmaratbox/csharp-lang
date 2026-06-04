static void Countdown(int n, List<int> acc)
{
    if (n < 1) return;
    acc.Add(n);
    Countdown(n - 1, acc);
}

var nums = new List<int>();
Countdown(5, nums);
Console.WriteLine(string.Join(' ', nums));
