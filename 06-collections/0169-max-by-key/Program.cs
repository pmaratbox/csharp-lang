string[] words = ["a", "bbb", "cc"];
string longest = words.MaxBy(w => w.Length)!;
Console.WriteLine(longest);
