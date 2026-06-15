using Sprache;

// A parser for a single integer, built with the Number combinator + Select (map).
var integer = Parse.Number.Select(int.Parse);

// A separated-list combinator: integers delimited by ','.
// DelimitedBy is Sprache's sepBy — it parses one-or-more `integer`
// separated by the `,` parser and yields the collection of results.
var commaSeparated = integer.DelimitedBy(Parse.Char(','));

// Run the combinator parser on the FIXED input string.
var numbers = commaSeparated.Parse("1,2,3");

Console.WriteLine(numbers.Sum());
