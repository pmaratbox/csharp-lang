var catalan = new List<long> { 1 };
long c = 1;
for (int n = 0; n < 4; n++)
{
    c = c * 2 * (2 * n + 1) / (n + 2);
    catalan.Add(c);
}

Console.WriteLine(string.Join(" ", catalan));
