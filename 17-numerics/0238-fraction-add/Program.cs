static int Gcd(int a, int b) => b == 0 ? a : Gcd(b, a % b);

int n1 = 1, d1 = 2, n2 = 1, d2 = 3;

int num = n1 * d2 + n2 * d1;
int den = d1 * d2;
int g = Gcd(Math.Abs(num), den);
num /= g;
den /= g;

Console.WriteLine($"{num}/{den}");
