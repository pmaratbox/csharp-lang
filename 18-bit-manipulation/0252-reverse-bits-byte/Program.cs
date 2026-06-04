byte x = 1;
int reversed = 0;
for (int i = 0; i < 8; i++)
    reversed |= ((x >> i) & 1) << (7 - i);
Console.WriteLine(reversed);
