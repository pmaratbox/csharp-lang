static int Moves(int n) => n == 0 ? 0 : 2 * Moves(n - 1) + 1;

Console.WriteLine(Moves(3));
