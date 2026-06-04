int[] coeffs = { 2, 3, 1 };
int x = 2;

int result = 0;
foreach (int c in coeffs)
    result = result * x + c;

Console.WriteLine(result);
