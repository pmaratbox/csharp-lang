using MathNet.Numerics.LinearAlgebra;

var a = Vector<double>.Build.DenseOfArray(new double[] { 1, 2, 3 });
var b = Vector<double>.Build.DenseOfArray(new double[] { 4, 5, 6 });

double dot = a.DotProduct(b);

Console.WriteLine((int)Math.Round(dot));
