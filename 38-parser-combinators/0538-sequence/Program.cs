using Sprache;

// Sequence: run parser `a` THEN parser `b`, combining both results.
// Sprache's LINQ query syntax chains parsers in sequence via `from ... in`.
var ab =
    from a in Parse.Char('a')
    from b in Parse.Char('b')
    select $"{a}{b}";

Console.WriteLine(ab.Parse("ab"));
