int[][] matrix = { new[] { 1, 2, 3 }, new[] { 4, 5, 6 } };
int rows = matrix.Length;
int cols = matrix[0].Length;

for (int j = 0; j < cols; j++)
{
    var parts = new List<string>();
    for (int i = 0; i < rows; i++)
    {
        parts.Add(matrix[i][j].ToString());
    }
    Console.WriteLine(string.Join(" ", parts));
}
