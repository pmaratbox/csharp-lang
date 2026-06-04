int[] items = [1, 2, 3];

void Permute(List<int> remaining, List<int> chosen)
{
    if (remaining.Count == 0)
    {
        Console.WriteLine(string.Join(' ', chosen));
        return;
    }
    for (int i = 0; i < remaining.Count; i++)
    {
        int value = remaining[i];
        List<int> rest = new(remaining);
        rest.RemoveAt(i);
        chosen.Add(value);
        Permute(rest, chosen);
        chosen.RemoveAt(chosen.Count - 1);
    }
}

Permute([.. items], []);
