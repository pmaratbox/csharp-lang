using MessagePack;

static string H(byte[] b) => Convert.ToHexString(b).ToLower();

// MessagePack-encode the integer 42 -> 2a (positive fixint).
Console.WriteLine(H(MessagePackSerializer.Serialize(42)));
