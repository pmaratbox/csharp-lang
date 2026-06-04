static long Power(long @base, int exp) =>
    exp == 0 ? 1 : @base * Power(@base, exp - 1);

Console.WriteLine(Power(2, 10));
