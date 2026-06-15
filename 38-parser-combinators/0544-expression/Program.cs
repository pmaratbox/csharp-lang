using Sprache;

// Parse a single integer.
var number = Parse.Number.Select(int.Parse);

// Parse a '+'-separated sequence of integers (sepBy via DelimitedBy),
// then fold the resulting list into its sum.
var expression = number
    .DelimitedBy(Parse.Char('+'))
    .Select(values => values.Sum());

var result = expression.Parse("10+20+30");
Console.WriteLine(result);
