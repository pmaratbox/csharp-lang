List<int> Merge(List<int> left, List<int> right)
{
    var result = new List<int>();
    int i = 0, j = 0;
    while (i < left.Count && j < right.Count)
    {
        if (left[i] <= right[j]) result.Add(left[i++]);
        else result.Add(right[j++]);
    }
    while (i < left.Count) result.Add(left[i++]);
    while (j < right.Count) result.Add(right[j++]);
    return result;
}

List<int> MergeSort(List<int> items)
{
    if (items.Count <= 1) return items;
    int mid = items.Count / 2;
    return Merge(MergeSort(items.GetRange(0, mid)), MergeSort(items.GetRange(mid, items.Count - mid)));
}

var data = new List<int> { 3, 1, 4, 1, 5, 2 };
Console.WriteLine(string.Join(" ", MergeSort(data)));
