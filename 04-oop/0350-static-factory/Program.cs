using System.Globalization;

var c = Color.FromHex("#ff0000");
Console.WriteLine($"{c.R} {c.G} {c.B}");

readonly record struct Color(int R, int G, int B)
{
    public static Color FromHex(string hex)
    {
        var s = hex.TrimStart('#');
        int Parse(int i) => int.Parse(s.Substring(i, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture);
        return new Color(Parse(0), Parse(2), Parse(4));
    }
}
