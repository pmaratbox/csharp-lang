using MessagePack;

static string H(byte[] b) => Convert.ToHexString(b).ToLower();

// MessagePack-encode the array [1, 2, 3] -> 93010203 (fixarray 93 + 01 02 03).
Console.WriteLine(H(MessagePackSerializer.Serialize(new[] { 1, 2, 3 })));
