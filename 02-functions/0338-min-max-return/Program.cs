(int Min, int Max) MinMaxReturn(int[] xs)
{
    int min = xs[0], max = xs[0];
    foreach (var x in xs)
    {
        if (x < min) min = x;
        if (x > max) max = x;
    }
    return (min, max);
}

var (min, max) = MinMaxReturn([4, 1, 7]);
Console.WriteLine($"{min} {max}");
