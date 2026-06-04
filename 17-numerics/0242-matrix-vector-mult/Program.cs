int[,] m = { { 1, 2 }, { 3, 4 } };
int[] v = { 5, 6 };

int[] result = new int[2];
for (int i = 0; i < 2; i++)
    for (int j = 0; j < 2; j++)
        result[i] += m[i, j] * v[j];

Console.WriteLine($"{result[0]} {result[1]}");
