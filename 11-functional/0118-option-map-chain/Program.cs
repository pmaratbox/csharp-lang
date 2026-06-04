int? present = 10;
int? absent = null;

int? Map(int? opt, Func<int, int> f) => opt is int v ? f(v) : null;

string Show(int? opt) => opt is int v ? v.ToString() : "none";

var mapped1 = Map(present, x => x + 2);
var mapped2 = Map(absent, x => x + 2);

Console.WriteLine($"{Show(mapped1)} {Show(mapped2)}");
