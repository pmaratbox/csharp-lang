using MessagePack;

static string H(byte[] b) => Convert.ToHexString(b).ToLower();

// MessagePack-encode the boolean true -> c3.
Console.WriteLine(H(MessagePackSerializer.Serialize(true)));
