int n = 5;
int a = 1, b = 1;
for (int i = 2; i <= n; i++)
    (a, b) = (b, a + b);
Console.WriteLine(b);
