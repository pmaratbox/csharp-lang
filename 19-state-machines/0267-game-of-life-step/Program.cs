var grid = new[,]
{
    { 0, 1, 0 },
    { 0, 1, 0 },
    { 0, 1, 0 },
};

var next = new int[3, 3];
for (var r = 0; r < 3; r++)
{
    for (var c = 0; c < 3; c++)
    {
        var live = 0;
        for (var dr = -1; dr <= 1; dr++)
        {
            for (var dc = -1; dc <= 1; dc++)
            {
                if (dr == 0 && dc == 0) continue;
                var nr = r + dr;
                var nc = c + dc;
                if (nr is >= 0 and < 3 && nc is >= 0 and < 3)
                    live += grid[nr, nc];
            }
        }
        next[r, c] = (grid[r, c] == 1) ? (live is 2 or 3 ? 1 : 0) : (live == 3 ? 1 : 0);
    }
}

for (var r = 0; r < 3; r++)
{
    var line = new char[3];
    for (var c = 0; c < 3; c++)
        line[c] = next[r, c] == 1 ? '#' : '.';
    Console.WriteLine(new string(line));
}
