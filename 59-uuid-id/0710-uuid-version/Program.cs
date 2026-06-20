using System;

// Parse a UUID with System.Guid and read its version. In the canonical
// string form the version is the single hex digit at index 14 (the first
// nibble of the third group). 550e8400-e29b-41d4-... -> '4' (a v4 UUID).
var guid = Guid.Parse("550e8400-e29b-41d4-a716-446655440000");
Console.WriteLine(guid.ToString()[14]);
