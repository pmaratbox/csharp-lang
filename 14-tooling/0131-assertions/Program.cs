static void Check(bool condition, string message)
{
    if (!condition)
        throw new Exception($"assertion failed: {message}");
}

Check(1 + 1 == 2, "1 + 1 == 2");
Check("ab" + "cd" == "abcd", "string concat");
Check(2 * 3 == 6, "2 * 3 == 6");

Console.WriteLine("all passed");
