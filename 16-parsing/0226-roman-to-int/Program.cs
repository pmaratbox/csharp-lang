var values = new Dictionary<char, int>
{
    ['I'] = 1, ['V'] = 5, ['X'] = 10, ['L'] = 50,
    ['C'] = 100, ['D'] = 500, ['M'] = 1000,
};

var roman = "XIV";
var total = 0;
for (var i = 0; i < roman.Length; i++)
{
    var cur = values[roman[i]];
    if (i + 1 < roman.Length && cur < values[roman[i + 1]]) total -= cur;
    else total += cur;
}
Console.WriteLine(total);
