using System.Numerics;

static int Parity(int n) => BitOperations.PopCount((uint)n) & 1;
Console.WriteLine($"{Parity(7)} {Parity(5)}");
