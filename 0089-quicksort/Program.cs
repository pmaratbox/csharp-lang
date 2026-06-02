List<int> Quicksort(List<int> items)
{
    if (items.Count <= 1) return items;
    int pivot = items[0];
    var rest = items.Skip(1);
    var less = rest.Where(x => x < pivot).ToList();
    var greater = rest.Where(x => x >= pivot).ToList();
    var result = Quicksort(less);
    result.Add(pivot);
    result.AddRange(Quicksort(greater));
    return result;
}

var data = new List<int> { 3, 1, 4, 1, 5, 2 };
Console.WriteLine(string.Join(" ", Quicksort(data)));
