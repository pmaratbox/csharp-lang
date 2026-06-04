var csv = "alice,30\nbob,25";

var pairs = csv
    .Split('\n')
    .Select(row => row.Split(','))
    .Select(cols => $"{cols[0]}={cols[1]}");

Console.WriteLine(string.Join(" ", pairs));
