T Largest<T>(T a, T b) where T : IComparable<T> => a.CompareTo(b) > 0 ? a : b;

Console.WriteLine(Largest(3, 9));
Console.WriteLine(Largest("apple", "pear"));
