using UUIDNext;

// UUIDv5 is name-based and deterministic: it is the SHA-1 hash of (namespace,
// name). Changing the name changes the UUID, so `test.com` yields a different
// value than `example.com` — yet always the same value for `test.com`.
var dns = Guid.Parse("6ba7b810-9dad-11d1-80b4-00c04fd430c8");
Console.WriteLine(Uuid.NewNameBased(dns, "test.com").ToString());
