using System.Security.Cryptography;
using System.Text;

var key = Encoding.UTF8.GetBytes("key");
var message = Encoding.UTF8.GetBytes("hello");
using var hmac = new HMACSHA256(key);
var digest = hmac.ComputeHash(message);
Console.WriteLine(Convert.ToHexString(digest).ToLower());
