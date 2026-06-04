static string B(bool v) => v ? "true" : "false";

foreach (var (a, b) in new[] { (true, true), (true, false), (false, true), (false, false) })
{
    Console.WriteLine($"{B(a)} {B(b)} {B(a && b)} {B(a || b)} {B(a ^ b)}");
}
