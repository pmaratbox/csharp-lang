using System.Globalization;

double target = 2.0;
double x = target;
for (int i = 0; i < 50; i++)
{
    double next = x - (x * x - target) / (2 * x);
    if (Math.Abs(next - x) < 1e-12) { x = next; break; }
    x = next;
}

Console.WriteLine(x.ToString("F4", CultureInfo.InvariantCulture));
