// Serilog with a custom ILogEventSink that captures the LogEvent in memory.
// We read e.Level, e.MessageTemplate.Text and e.Properties — no real timestamp
// reaches the output. A WARN record is emitted and its level is normalized to "warn".
using Serilog;
using Serilog.Core;
using Serilog.Events;

var sink = new Capture();
var log = new LoggerConfiguration()
    .MinimumLevel.Warning()
    .WriteTo.Sink(sink)
    .CreateLogger();

log.Warning("low disk");

foreach (var line in sink.Lines) Console.WriteLine(line);

class Capture : ILogEventSink
{
    public List<string> Lines = new();

    static string Lvl(LogEventLevel l) => l switch
    {
        LogEventLevel.Information => "info",
        LogEventLevel.Warning => "warn",
        LogEventLevel.Error => "error",
        LogEventLevel.Debug => "debug",
        _ => l.ToString().ToLower()
    };

    public void Emit(LogEvent e)
    {
        var fields = e.Properties.OrderBy(p => p.Key)
            .Select(p => $"|{p.Key}={p.Value.ToString().Trim('"')}");
        Lines.Add($"{Lvl(e.Level)}|{e.MessageTemplate.Text}" + string.Concat(fields));
    }
}
