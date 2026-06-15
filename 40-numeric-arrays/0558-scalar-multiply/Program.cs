using MathNet.Numerics.LinearAlgebra;

var a = Matrix<double>.Build.DenseOfArray(new double[,] { { 1, 2 }, { 3, 4 } });
var c = a * 3.0;
for (int i = 0; i < 2; i++)
    Console.WriteLine(string.Join(" ", Enumerable.Range(0, 2).Select(j => ((int)Math.Round(c[i, j])).ToString())));
