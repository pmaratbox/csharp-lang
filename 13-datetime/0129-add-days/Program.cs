using System.Globalization;

static long DaysFromCivil(int y, int m, int d)
{
    y -= m <= 2 ? 1 : 0;
    long era = (y >= 0 ? y : y - 399) / 400;
    long yoe = y - era * 400;
    long doy = (153 * (m + (m > 2 ? -3 : 9)) + 2) / 5 + d - 1;
    long doe = yoe * 365 + yoe / 4 - yoe / 100 + doy;
    return era * 146097 + doe - 719468;
}

static (int y, int m, int d) CivilFromDays(long z)
{
    z += 719468;
    long era = (z >= 0 ? z : z - 146096) / 146097;
    long doe = z - era * 146097;
    long yoe = (doe - doe / 1460 + doe / 36524 - doe / 146096) / 365;
    long y = yoe + era * 400;
    long doy = doe - (365 * yoe + yoe / 4 - yoe / 100);
    long mp = (5 * doy + 2) / 153;
    long d = doy - (153 * mp + 2) / 5 + 1;
    long m = mp + (mp < 10 ? 3 : -9);
    return ((int)(y + (m <= 2 ? 1 : 0)), (int)m, (int)d);
}

var (y, m, d) = CivilFromDays(DaysFromCivil(2000, 1, 1) + 40);
Console.WriteLine(string.Format(CultureInfo.InvariantCulture, "{0:D4}-{1:D2}-{2:D2}", y, m, d));
