using System.Globalization;

var matrix = new SparseMatrix();
matrix[1, 1] = 5;

Console.WriteLine(string.Join(" ",
    matrix[1, 1].ToString(CultureInfo.InvariantCulture),
    matrix[0, 0].ToString(CultureInfo.InvariantCulture)));

sealed class SparseMatrix
{
    private readonly Dictionary<(int Row, int Col), int> entries = new();

    public int this[int row, int col]
    {
        get => entries.GetValueOrDefault((row, col));
        set
        {
            if (value == 0)
                entries.Remove((row, col));
            else
                entries[(row, col)] = value;
        }
    }
}
