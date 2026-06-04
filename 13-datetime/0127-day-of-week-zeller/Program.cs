static string Weekday(int year, int month, int day)
{
    // Zeller's congruence: treat Jan/Feb as months 13/14 of the prior year.
    if (month < 3)
    {
        month += 12;
        year -= 1;
    }

    int k = year % 100;
    int j = year / 100;
    int h = (day + 13 * (month + 1) / 5 + k + k / 4 + j / 4 + 5 * j) % 7;

    // h: 0=Saturday, 1=Sunday, ... 6=Friday
    string[] names =
    [
        "Saturday", "Sunday", "Monday", "Tuesday",
        "Wednesday", "Thursday", "Friday",
    ];
    return names[h];
}

Console.WriteLine(Weekday(2000, 1, 1));
