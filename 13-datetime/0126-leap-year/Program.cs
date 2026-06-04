static bool IsLeap(int year) =>
    year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);

string Word(int year) => IsLeap(year) ? "yes" : "no";

Console.WriteLine($"{Word(2000)} {Word(1900)} {Word(2024)}");
