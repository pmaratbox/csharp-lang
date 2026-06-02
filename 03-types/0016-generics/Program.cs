int[] ints = { 1, 2, 3 };
string[] strs = { "a", "b", "c" };

Console.WriteLine($"first int: {First(ints)}");
Console.WriteLine($"first string: {First(strs)}");

static T First<T>(IReadOnlyList<T> items) => items[0];
