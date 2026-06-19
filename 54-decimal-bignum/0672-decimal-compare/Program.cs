// Exact decimal comparison with C#'s built-in `decimal` type (base-10, no float rounding).
// With binary floats 0.1 + 0.2 != 0.3; with exact base-10 decimals it is exactly equal.
decimal sum = 0.1m + 0.2m;
bool equal = sum == 0.3m;
Console.WriteLine(equal.ToString().ToLower());   // true
