static int Sign(int x) => x < 0 ? -1 : x > 0 ? 1 : 0;

Console.WriteLine($"{Sign(-5)} {Sign(0)} {Sign(5)}");
