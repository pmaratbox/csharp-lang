int n = 1234;
int reversed = 0;

while (n != 0)
{
    reversed = reversed * 10 + n % 10;
    n /= 10;
}

Console.WriteLine(reversed);
