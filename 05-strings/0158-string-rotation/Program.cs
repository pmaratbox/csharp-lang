const string a = "abcd";
const string b = "cdab";
bool isRotation = a.Length == b.Length && (a + a).Contains(b, StringComparison.Ordinal);
Console.WriteLine(isRotation ? "yes" : "no");
