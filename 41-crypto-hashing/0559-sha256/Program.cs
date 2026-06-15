using System.Security.Cryptography;
using System.Text;

var digest = SHA256.HashData(Encoding.UTF8.GetBytes("hello"));
Console.WriteLine(Convert.ToHexString(digest).ToLower());
