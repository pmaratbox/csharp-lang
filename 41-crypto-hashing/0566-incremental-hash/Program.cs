using System.Security.Cryptography;
using System.Text;

using var hasher = IncrementalHash.CreateHash(HashAlgorithmName.SHA256);
hasher.AppendData(Encoding.UTF8.GetBytes("foo"));
hasher.AppendData(Encoding.UTF8.GetBytes("bar"));
var digest = hasher.GetHashAndReset();
Console.WriteLine(Convert.ToHexString(digest).ToLower());
