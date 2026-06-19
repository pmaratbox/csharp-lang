using MessagePack;

var bytes = Convert.FromHexString("a568656c6c6f");
string value = MessagePackSerializer.Deserialize<string>(bytes);
Console.WriteLine(value);
