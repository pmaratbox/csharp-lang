using Sprache;

// Choice combinator: try the first parser, and if it fails,
// fall back to the second. Sprache spells choice as `.Or(...)`.
var cat = Parse.String("cat").Text();
var dog = Parse.String("dog").Text();
var animal = cat.Or(dog);

Console.WriteLine(animal.Parse("dog"));
