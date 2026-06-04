static long DaysFromCivil(int y, int m, int d)
{
    y -= m <= 2 ? 1 : 0;
    long era = (y >= 0 ? y : y - 399) / 400;
    long yoe = y - era * 400;
    long doy = (153 * (m + (m > 2 ? -3 : 9)) + 2) / 5 + d - 1;
    long doe = yoe * 365 + yoe / 4 - yoe / 100 + doy;
    return era * 146097 + doe - 719468;
}

long days = DaysFromCivil(2000, 12, 31) - DaysFromCivil(2000, 1, 1);
Console.WriteLine(days);
