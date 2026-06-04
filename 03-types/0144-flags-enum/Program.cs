var flags = Access.Read | Access.Write;
var hasWrite = (flags & Access.Write) != 0 ? "yes" : "no";
Console.WriteLine($"{(int)flags} {hasWrite}");

[Flags]
enum Access
{
    Read = 1,
    Write = 2,
}
