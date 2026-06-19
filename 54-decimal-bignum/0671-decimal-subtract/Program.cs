// Exact decimal subtraction with C#'s built-in `decimal` type (base-10, no float rounding).
// CRITICAL: decimal.ToString MUST use CultureInfo.InvariantCulture (machine locale uses a comma!).
using System.Globalization;

var inv = CultureInfo.InvariantCulture;
decimal result = 1.0m - 0.1m;
Console.WriteLine(result.ToString(inv));   // 0.9
