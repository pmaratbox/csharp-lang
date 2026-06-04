static bool Balanced(string s)
{
    var pairs = new Dictionary<char, char> { [')'] = '(', [']'] = '[', ['}'] = '{' };
    var stack = new Stack<char>();
    foreach (var ch in s)
    {
        if (ch is '(' or '[' or '{') stack.Push(ch);
        else if (pairs.TryGetValue(ch, out var open))
        {
            if (stack.Count == 0 || stack.Pop() != open) return false;
        }
    }
    return stack.Count == 0;
}

Console.WriteLine($"{(Balanced("([{}])") ? "yes" : "no")} {(Balanced("([)]") ? "yes" : "no")}");
