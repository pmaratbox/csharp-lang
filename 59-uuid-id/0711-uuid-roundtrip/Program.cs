// System.Guid parses a UUID case-insensitively. Calling ToString() returns
// the canonical lowercase, hyphenated form — so an uppercase input round-trips
// to its canonical lowercase representation.
Console.WriteLine(Guid.Parse("550E8400-E29B-41D4-A716-446655440000").ToString());
