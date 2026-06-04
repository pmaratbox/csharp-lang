ILogger nullLogger = new NullLogger();
var realLogger = new RealLogger();

nullLogger.Log("ignored");
realLogger.Log("recorded");

Console.WriteLine(realLogger.Count);

interface ILogger { void Log(string message); }

sealed class NullLogger : ILogger
{
    public void Log(string message) { }
}

sealed class RealLogger : ILogger
{
    public int Count { get; private set; }
    public void Log(string message) => Count++;
}
