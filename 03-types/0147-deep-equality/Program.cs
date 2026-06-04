var a = new Nested(new Pair(1, 2), new Pair(3, 4));
var b = new Nested(new Pair(1, 2), new Pair(3, 4));

Console.WriteLine($"equal: {(a == b ? "yes" : "no")}");

record Pair(int First, int Second);
record Nested(Pair Left, Pair Right);
