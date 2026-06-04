static long Ackermann(long m, long n) =>
    m == 0 ? n + 1
    : n == 0 ? Ackermann(m - 1, 1)
    : Ackermann(m - 1, Ackermann(m, n - 1));

Console.WriteLine(Ackermann(2, 3));
