var trie = new Trie();
trie.Insert("cat");
trie.Insert("car");
Console.WriteLine($"{(trie.Search("car") ? "yes" : "no")} {(trie.Search("can") ? "yes" : "no")}");

class TrieNode
{
    public Dictionary<char, TrieNode> Children = new();
    public bool IsWord;
}

class Trie
{
    private readonly TrieNode _root = new();

    public void Insert(string word)
    {
        var node = _root;
        foreach (var c in word)
        {
            if (!node.Children.TryGetValue(c, out var next))
                node.Children[c] = next = new TrieNode();
            node = next;
        }
        node.IsWord = true;
    }

    public bool Search(string word)
    {
        var node = _root;
        foreach (var c in word)
        {
            if (!node.Children.TryGetValue(c, out var next)) return false;
            node = next;
        }
        return node.IsWord;
    }
}
