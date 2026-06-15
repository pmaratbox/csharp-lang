using Sprache;

// many(char 'a'): the .Many() combinator applies a parser zero-or-more times,
// collecting every match into a sequence.
var manyA = Parse.Char('a').Many();

var parsed = manyA.Parse("aaaa");
Console.WriteLine(parsed.Count());
