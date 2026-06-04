var cell = 0;
foreach (var op in "+++")
{
    if (op == '+') cell++;
    else if (op == '-') cell--;
}
Console.WriteLine(cell);
