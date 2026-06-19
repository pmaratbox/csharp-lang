using MessagePack;

static string Hex(byte[] b) => Convert.ToHexString(b).ToLower();

byte[] encoded = MessagePackSerializer.Serialize("hello");
Console.WriteLine(Hex(encoded));
