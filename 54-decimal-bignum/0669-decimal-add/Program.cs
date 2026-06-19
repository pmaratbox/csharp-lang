using System.Globalization;

var inv = CultureInfo.InvariantCulture;

// decimal is an exact base-10 type, so 0.1 + 0.2 is precisely 0.3
// (a binary float would give 0.30000000000000004).
decimal sum = 0.1m + 0.2m;
Console.WriteLine(sum.ToString(inv));
