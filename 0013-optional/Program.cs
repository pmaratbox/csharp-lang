int? present = 42;
int? absent = null;

Console.WriteLine($"present: {present ?? -1}");
Console.WriteLine($"absent: {absent ?? -1}");
