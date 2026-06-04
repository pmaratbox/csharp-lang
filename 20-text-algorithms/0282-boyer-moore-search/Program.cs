string text = "zzabc";
string pattern = "abc";

Dictionary<char, int> last = new();
for (int i = 0; i < pattern.Length; i++)
    last[pattern[i]] = i;

int result = -1;
int s = 0;
while (s <= text.Length - pattern.Length)
{
    int j = pattern.Length - 1;
    while (j >= 0 && pattern[j] == text[s + j]) j--;

    if (j < 0)
    {
        result = s;
        break;
    }

    int badShift = j - last.GetValueOrDefault(text[s + j], -1);
    s += Math.Max(1, badShift);
}

Console.WriteLine(result);
