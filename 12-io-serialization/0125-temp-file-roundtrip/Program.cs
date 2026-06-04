var path = Path.GetTempFileName();
File.WriteAllText(path, "ok-data");

var readBack = File.ReadAllText(path);
var ok = readBack == "ok-data";
File.Delete(path);

Console.WriteLine($"roundtrip: {(ok ? "ok" : "fail")}");
