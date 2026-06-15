using MathNet.Numerics.LinearAlgebra;

var a = Matrix<double>.Build.DenseOfArray(new double[,] { { 1, 2, 3 }, { 4, 5, 6 } });
var t = a.Transpose();

for (int i = 0; i < t.RowCount; i++)
    Console.WriteLine(string.Join(" ", Enumerable.Range(0, t.ColumnCount).Select(j => ((int)Math.Round(t[i, j])).ToString())));
