var threshold = Level.WARN;

void Log(Level level, string msg)
{
    if (level >= threshold)
        Console.WriteLine($"{level}: {msg}");
}

Log(Level.INFO, "i");
Log(Level.WARN, "w");
Log(Level.ERROR, "e");

enum Level { INFO, WARN, ERROR }
