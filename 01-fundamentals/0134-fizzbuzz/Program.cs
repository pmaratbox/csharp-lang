for (int i = 1; i <= 15; i++)
{
    Console.WriteLine((i % 15, i % 3, i % 5) switch
    {
        (0, _, _) => "FizzBuzz",
        (_, 0, _) => "Fizz",
        (_, _, 0) => "Buzz",
        _ => i.ToString(),
    });
}
