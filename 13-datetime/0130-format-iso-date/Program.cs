using System.Globalization;

int y = 2026, m = 6, d = 4;
Console.WriteLine(string.Format(CultureInfo.InvariantCulture, "{0:D4}-{1:D2}-{2:D2}", y, m, d));
