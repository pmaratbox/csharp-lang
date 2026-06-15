using System.Security.Cryptography;
using System.Text;
var d = SHA512.HashData(Encoding.UTF8.GetBytes("hello"));
Console.WriteLine(Convert.ToHexString(d).ToLower());
