foreach (int n in new[] { 4, 7 })
{
    string label = n % 2 == 0 ? "even" : "odd";
    Console.WriteLine($"{n}: {label}");
}
