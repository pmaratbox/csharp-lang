var word = "hello";
var vowels = "aeiou";
int count = word.Count(ch => vowels.Contains(ch));
Console.WriteLine(count);
