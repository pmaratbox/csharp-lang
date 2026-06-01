void Inc(ref int n)
{
    n++;
}

int n = 1;
Console.WriteLine($"before: {n}");
Inc(ref n);
Console.WriteLine($"after: {n}");
