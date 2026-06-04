static int Clamp(int x, int lo, int hi) => Math.Max(lo, Math.Min(x, hi));

Console.WriteLine($"{Clamp(15, 0, 10)} {Clamp(-3, 0, 10)}");
