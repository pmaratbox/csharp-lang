using Sprache;

// Sprache combinators: Parse.Number captures a run of digits; wrapping it with
// .Token() makes the parser skip surrounding whitespace (Parse.WhiteSpace.Many())
// before and after the number, then .Select(...) maps the digits into an int.
var integer = Parse.Number
    .Select(int.Parse)
    .Token();

int value = integer.Parse("  42  ");
Console.WriteLine(value);
