string Word(int n) => n switch
{
    1 => "one",
    2 => "two",
    _ => "many",
};

foreach (int n in new[] { 1, 2, 5 })
{
    Console.WriteLine($"{n}: {Word(n)}");
}
