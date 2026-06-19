using MessagePack;

static string H(byte[] b) => Convert.ToHexString(b).ToLower();

// MessagePack-encode null/nil -> c0 (the dedicated nil byte).
Console.WriteLine(H(MessagePackSerializer.Serialize<object?>(null)));
