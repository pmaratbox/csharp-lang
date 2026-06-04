var row = "00100";
var n = row.Length;
var next = new char[n];
for (var i = 0; i < n; i++)
{
    var left = i > 0 ? row[i - 1] - '0' : 0;
    var right = i < n - 1 ? row[i + 1] - '0' : 0;
    next[i] = (char)('0' + (left ^ right));
}

Console.WriteLine(new string(next));
