using MathNet.Numerics.LinearAlgebra;

var a = Matrix<double>.Build.DenseOfArray(new double[,] { { 1, 2 }, { 3, 4 } });
var b = Matrix<double>.Build.DenseOfArray(new double[,] { { 5, 6 }, { 7, 8 } });

var c = a * b;

for (int i = 0; i < c.RowCount; i++)
    Console.WriteLine(string.Join(" ",
        Enumerable.Range(0, c.ColumnCount)
            .Select(j => ((int)Math.Round(c[i, j])).ToString())));
