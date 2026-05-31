Console.WriteLine($"10 / 2 = {Divide(10, 2)}");

try
{
    Divide(10, 0);
}
catch (DivideByZeroException e)
{
    Console.WriteLine($"error: {e.Message}");
}

static int Divide(int a, int b)
{
    if (b == 0)
    {
        throw new DivideByZeroException("division by zero");
    }
    return a / b;
}
