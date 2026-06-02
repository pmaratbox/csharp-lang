var text = "abc";
int shift = 1;
var result = new string(text.Select(ch => (char)((ch - 'a' + shift) % 26 + 'a')).ToArray());
Console.WriteLine(result);
