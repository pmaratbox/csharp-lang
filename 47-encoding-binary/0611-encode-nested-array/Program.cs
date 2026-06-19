using MessagePack;

static string H(byte[] b) => Convert.ToHexString(b).ToLower();

// MessagePack-encode the nested array [[1,2],[3,4]] -> 92920102920304
// (outer fixarray 92 + two inner fixarrays 92 01 02 / 92 03 04).
Console.WriteLine(H(MessagePackSerializer.Serialize(new[] { new[] { 1, 2 }, new[] { 3, 4 } })));
