using MessagePack;

static string H(byte[] b) => Convert.ToHexString(b).ToLower();

// MessagePack-encode the single-key map {"a": 1} -> 81a16101
// (fixmap 81 + key a161 + value 01).
Console.WriteLine(H(MessagePackSerializer.Serialize(new Dictionary<string, int> { ["a"] = 1 })));
