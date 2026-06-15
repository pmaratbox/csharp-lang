using MathNet.Numerics.LinearAlgebra;

var v = Vector<double>.Build.DenseOfArray(new double[] { 1, 2, 3, 4 });
var total = v.Sum();
Console.WriteLine(((int)Math.Round(total)).ToString());
