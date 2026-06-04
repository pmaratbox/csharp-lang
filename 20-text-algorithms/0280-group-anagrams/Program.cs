string[] words = ["eat", "tea", "tan", "ate", "nat"];

var groups = words
    .GroupBy(w => new string(w.OrderBy(c => c).ToArray()))
    .ToList();

Console.WriteLine(groups.Count);
