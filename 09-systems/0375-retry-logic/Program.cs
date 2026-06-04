const int maxAttempts = 5;

for (int attempt = 1; attempt <= maxAttempts; attempt++)
{
    if (attempt >= 3)
    {
        Console.WriteLine($"ok after {attempt}");
        break;
    }
}
