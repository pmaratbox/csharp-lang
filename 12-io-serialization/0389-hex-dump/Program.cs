using System.Text;

var bytes = Encoding.ASCII.GetBytes("Hi");
var hex = bytes.Select(b => b.ToString("x2"));
Console.WriteLine(string.Join(' ', hex));
