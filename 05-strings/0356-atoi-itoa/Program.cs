static int Atoi(string s)
{
    int i = 0, sign = 1;
    if (s[i] == '-') { sign = -1; i++; }
    else if (s[i] == '+') i++;
    int n = 0;
    for (; i < s.Length; i++) n = n * 10 + (s[i] - '0');
    return sign * n;
}

static string Itoa(int n)
{
    if (n == 0) return "0";
    bool neg = n < 0;
    long v = Math.Abs((long)n);
    var sb = new System.Text.StringBuilder();
    while (v > 0) { sb.Insert(0, (char)('0' + v % 10)); v /= 10; }
    if (neg) sb.Insert(0, '-');
    return sb.ToString();
}

int parsed = Atoi("-42");
Console.WriteLine($"{parsed} {Itoa(parsed)}");
