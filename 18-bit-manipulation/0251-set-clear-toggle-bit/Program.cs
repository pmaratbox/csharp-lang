int set = 0 | (1 << 1);
int clear = 2 & ~(1 << 1);
int toggle = 0 ^ (1 << 1);
Console.WriteLine($"{set} {clear} {toggle}");
