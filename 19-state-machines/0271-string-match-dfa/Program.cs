var pattern = "ab";
var text = "aab";

// DFA state = number of pattern chars matched so far.
var state = 0;
var match = -1;
for (var i = 0; i < text.Length; i++)
{
    if (text[i] == pattern[state])
        state++;
    else
        state = text[i] == pattern[0] ? 1 : 0;

    if (state == pattern.Length)
    {
        match = i - pattern.Length + 1;
        break;
    }
}

Console.WriteLine(match);
