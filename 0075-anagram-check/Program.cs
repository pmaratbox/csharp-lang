bool Anagram(string a, string b)
{
    var x = a.ToCharArray();
    var y = b.ToCharArray();
    Array.Sort(x);
    Array.Sort(y);
    return x.SequenceEqual(y);
}

var pairs = new[] { ("listen", "silent"), ("hello", "world") };
foreach (var (a, b) in pairs)
{
    Console.WriteLine($"{a}/{b}: {(Anagram(a, b) ? "yes" : "no")}");
}
