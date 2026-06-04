var value = 258;
byte high = (byte)(value >> 8);
byte low = (byte)(value & 0xFF);
int decoded = high * 256 + low;
Console.WriteLine($"{high} {low} {decoded}");
