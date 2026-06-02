bool IsPalindrome(string s)
{
    var chars = s.ToCharArray();
    Array.Reverse(chars);
    return s == new string(chars);
}

foreach (var word in new[] { "level", "hello" })
{
    Console.WriteLine($"{word}: {(IsPalindrome(word) ? "yes" : "no")}");
}
