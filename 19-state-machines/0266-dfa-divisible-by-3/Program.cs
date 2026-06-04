static bool DivBy3(string bits)
{
    var state = 0;
    foreach (var c in bits)
        state = (state * 2 + (c - '0')) % 3;
    return state == 0;
}

Console.WriteLine($"{(DivBy3("110") ? "yes" : "no")} {(DivBy3("100") ? "yes" : "no")}");
