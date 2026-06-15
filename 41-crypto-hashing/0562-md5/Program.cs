using System.Security.Cryptography;
using System.Text;
var d = MD5.HashData(Encoding.UTF8.GetBytes("hello"));
Console.WriteLine(Convert.ToHexString(d).ToLower());
