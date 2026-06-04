int n = 90210, count = 0;
do { count++; n /= 10; } while (n != 0);
Console.WriteLine(count);
