// Exact decimal multiplication with C#'s built-in `decimal` type (base-10, no float rounding).
// CRITICAL: decimal.ToString MUST use CultureInfo.InvariantCulture (machine locale uses a comma!).
using System.Globalization;

var inv = CultureInfo.InvariantCulture;
decimal result = 1.1m * 1.1m;
Console.WriteLine(result.ToString(inv));   // 1.21
