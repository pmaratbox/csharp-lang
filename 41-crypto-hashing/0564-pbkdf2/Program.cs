using System.Security.Cryptography;
using System.Text;

byte[] password = Encoding.UTF8.GetBytes("password");
byte[] salt = Encoding.UTF8.GetBytes("salt");

byte[] derived = Rfc2898DeriveBytes.Pbkdf2(
    password, salt, 1000, HashAlgorithmName.SHA256, 32);

Console.WriteLine(Convert.ToHexString(derived).ToLower());
