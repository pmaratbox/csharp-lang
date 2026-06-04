static int Gcd(int a, int b) => b == 0 ? a : Gcd(b, a % b);

int num = 6, den = 8;
int g = Gcd(num, den);

Console.WriteLine($"{num / g}/{den / g}");
