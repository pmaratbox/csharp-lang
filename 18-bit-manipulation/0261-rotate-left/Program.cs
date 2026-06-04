static int Rol8(int x, int n) => ((x << n) | (x >> (8 - n))) & 0xff;
Console.WriteLine($"{Rol8(1, 1)} {Rol8(128, 1)}");
