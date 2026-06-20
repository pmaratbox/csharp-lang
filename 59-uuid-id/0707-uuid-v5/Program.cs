using UUIDNext;

// UUIDv5 is name-based: a SHA-1 hash of (namespace, name) deterministically
// produces the same UUID every time. No randomness is involved.
var dns = Guid.Parse("6ba7b810-9dad-11d1-80b4-00c04fd430c8");
Console.WriteLine(Uuid.NewNameBased(dns, "example.com").ToString());
