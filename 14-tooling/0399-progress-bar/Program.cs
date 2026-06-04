int width = 10;
double pct = 0.4;
int filled = (int)Math.Round(width * pct);

Console.WriteLine($"[{new string('#', filled)}{new string('-', width - filled)}]");
