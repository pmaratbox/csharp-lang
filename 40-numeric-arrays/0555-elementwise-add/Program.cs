using MathNet.Numerics.LinearAlgebra;

var a = Vector<double>.Build.DenseOfArray(new double[] { 1, 2, 3 });
var b = Vector<double>.Build.DenseOfArray(new double[] { 10, 20, 30 });

var sum = a + b;

Console.WriteLine(string.Join(" ", sum.Select(v => ((int)Math.Round(v)).ToString())));
