static string Rot13(string s) =>
    new string(s.Select(c =>
        char.IsLetter(c)
            ? (char)((char.IsUpper(c) ? 'A' : 'a') + (c - (char.IsUpper(c) ? 'A' : 'a') + 13) % 26)
            : c).ToArray());

string once = Rot13("hello");
string twice = Rot13(once);
Console.WriteLine($"{once} {twice}");
