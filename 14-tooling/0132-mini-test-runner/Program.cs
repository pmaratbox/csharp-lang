var tests = new List<(string Name, Action Body)>
{
    ("test_addition", () => { if (1 + 1 != 2) throw new Exception("addition"); }),
    ("test_concat", () => { if ("a" + "b" != "ab") throw new Exception("concat"); }),
    ("test_compare", () => { if (!(3 > 2)) throw new Exception("compare"); }),
};

int passed = 0, failed = 0;
foreach (var (name, body) in tests)
{
    try
    {
        body();
        passed++;
    }
    catch
    {
        failed++;
    }
}

Console.WriteLine($"{passed} passed, {failed} failed");
