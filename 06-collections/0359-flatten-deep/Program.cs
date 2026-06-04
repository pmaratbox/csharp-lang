object nested = new List<object>
{
    1,
    new List<object> { 2, new List<object> { 3, 4 } },
    5
};

IEnumerable<int> Flatten(object node)
{
    if (node is List<object> list)
    {
        foreach (var child in list)
            foreach (var leaf in Flatten(child))
                yield return leaf;
    }
    else
    {
        yield return (int)node;
    }
}

Console.WriteLine(string.Join(" ", Flatten(nested)));
