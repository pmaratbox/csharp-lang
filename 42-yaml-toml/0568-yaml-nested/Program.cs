using YamlDotNet.Serialization;

var de = new DeserializerBuilder().Build();
var doc = de.Deserialize<Dictionary<string, object>>("server:\n  host: localhost\n  port: 8080\n");

var server = (Dictionary<object, object>)doc["server"];
Console.WriteLine($"{server["host"]}:{server["port"]}");
