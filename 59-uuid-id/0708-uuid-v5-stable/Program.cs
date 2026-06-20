using UUIDNext;
using System;

// UUIDv5 (SHA-1, name-based) is deterministic: the same (namespace, name)
// always produces the same UUID. Generate it twice and compare.
var dns = Guid.Parse("6ba7b810-9dad-11d1-80b4-00c04fd430c8");
var a = Uuid.NewNameBased(dns, "example.com");
var b = Uuid.NewNameBased(dns, "example.com");
Console.WriteLine((a == b).ToString().ToLower());
