int bits = 0b101;

string rwx = string.Concat(
    (bits & 0b100) != 0 ? "r" : "-",
    (bits & 0b010) != 0 ? "w" : "-",
    (bits & 0b001) != 0 ? "x" : "-");

Console.WriteLine(rwx);
