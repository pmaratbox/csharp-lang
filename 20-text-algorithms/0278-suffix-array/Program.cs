string s = "banana";

int[] sa = Enumerable.Range(0, s.Length).ToArray();
Array.Sort(sa, (i, j) => string.CompareOrdinal(s[i..], s[j..]));

Console.WriteLine(string.Join(' ', sa));
