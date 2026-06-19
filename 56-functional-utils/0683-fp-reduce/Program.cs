// Reduce/fold [1..5] with addition (seed 0) using LINQ's Aggregate (System.Linq, stdlib).
Console.WriteLine(Enumerable.Range(1, 5).Aggregate(0, (sum, x) => sum + x));
