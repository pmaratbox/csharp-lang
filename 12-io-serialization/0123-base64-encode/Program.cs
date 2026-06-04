using System.Text;

var encoded = Convert.ToBase64String(Encoding.UTF8.GetBytes("hi"));

Console.WriteLine(encoded);
