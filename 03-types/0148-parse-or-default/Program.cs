using System.Globalization;

int ParseOrDefault(string s) =>
    int.TryParse(s, NumberStyles.Integer, CultureInfo.InvariantCulture, out var value) ? value : 0;

Console.WriteLine($"{ParseOrDefault("42")} {ParseOrDefault("x")}");
