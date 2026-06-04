var root = new TrieNode();

void Insert(string word)
{
    var node = root;
    foreach (char c in word)
    {
        if (!node.Children.TryGetValue(c, out var next))
        {
            next = new TrieNode();
            node.Children[c] = next;
        }
        node = next;
    }
    node.IsWord = true;
}

void Collect(TrieNode node, string prefix, List<string> acc)
{
    if (node.IsWord) acc.Add(prefix);
    foreach (var (c, child) in node.Children.OrderBy(kv => kv.Key))
        Collect(child, prefix + c, acc);
}

List<string> Autocomplete(string prefix)
{
    var node = root;
    foreach (char c in prefix)
    {
        if (!node.Children.TryGetValue(c, out var next))
            return new List<string>();
        node = next;
    }
    List<string> acc = new();
    Collect(node, prefix, acc);
    return acc;
}

Insert("car");
Insert("card");
Insert("dog");

Console.WriteLine(string.Join(' ', Autocomplete("car")));

sealed class TrieNode
{
    public Dictionary<char, TrieNode> Children { get; } = new();
    public bool IsWord { get; set; }
}
