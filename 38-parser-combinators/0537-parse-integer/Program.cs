using Sprache;

// Sprache combinators: Parse.Digit.AtLeastOnce() matches one-or-more digit
// characters, then .Select(...) maps the captured run into an int.
var integer = Parse.Digit.AtLeastOnce()
    .Select(digits => int.Parse(new string(digits.ToArray())));

int value = integer.Parse("42");
Console.WriteLine(value);
