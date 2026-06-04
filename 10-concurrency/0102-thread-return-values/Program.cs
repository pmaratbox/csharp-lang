var results = new int[2];

var t1 = new Thread(() => results[0] = 3 * 3);
var t2 = new Thread(() => results[1] = 4 * 4);

t1.Start();
t2.Start();
t1.Join();
t2.Join();

Console.WriteLine(results[0] + results[1]);
