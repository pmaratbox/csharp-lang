using System.Globalization;

double d = 3.9;
int i = (int)d; // truncates toward zero

int n = 3;
double widened = n;

Console.WriteLine($"{i} {widened.ToString("0.0", CultureInfo.InvariantCulture)}");
