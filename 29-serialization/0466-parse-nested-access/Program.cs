using System.Text.Json.Nodes;

var json = "{\"user\":{\"name\":\"alice\",\"roles\":[\"admin\",\"user\"]}}";

var root = JsonNode.Parse(json)!;

var name = (string)root["user"]!["name"]!;
var firstRole = (string)root["user"]!["roles"]![0]!;

Console.WriteLine($"{name} {firstRole}");
