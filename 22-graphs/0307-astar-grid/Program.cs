const int Size = 3;
var goal = (r: 2, c: 2);
int H((int r, int c) p) => Math.Abs(p.r - goal.r) + Math.Abs(p.c - goal.c);

var start = (r: 0, c: 0);
var g = new Dictionary<(int, int), int> { [start] = 0 };
var open = new PriorityQueue<(int r, int c), int>();
open.Enqueue(start, H(start));
int[] dr = { 1, -1, 0, 0 }, dc = { 0, 0, 1, -1 };

while (open.TryDequeue(out var cur, out _))
{
    if (cur == goal) { Console.WriteLine(g[cur]); return; }
    for (int k = 0; k < 4; k++)
    {
        var nxt = (r: cur.r + dr[k], c: cur.c + dc[k]);
        if (nxt.r < 0 || nxt.r >= Size || nxt.c < 0 || nxt.c >= Size) continue;
        int ng = g[cur] + 1;
        if (!g.TryGetValue(nxt, out int old) || ng < old)
        {
            g[nxt] = ng;
            open.Enqueue(nxt, ng + H(nxt));
        }
    }
}
