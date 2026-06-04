static bool IsPow2(int n) => n > 0 && (n & (n - 1)) == 0;
Console.WriteLine($"{(IsPow2(16) ? "yes" : "no")} {(IsPow2(18) ? "yes" : "no")}");
