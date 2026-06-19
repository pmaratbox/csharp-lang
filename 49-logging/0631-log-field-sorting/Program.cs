// Serilog with a custom ILogEventSink that captures the LogEvent in-memory (no real timestamp).
// Fields are attached in NON-alphabetical order (zeta then alpha) via .ForContext(k, v),
// with a plain message logged at info level. The sink reads e.Level + e.MessageTemplate.Text
// + e.Properties, sorting the fields by key so output is deterministic regardless of attach order.
using Serilog;
using Serilog.Core;
using Serilog.Events;

var sink = new Capture();
var log = new LoggerConfiguration()
    .MinimumLevel.Information()
    .WriteTo.Sink(sink)
    .CreateLogger();

log.ForContext("zeta", 2).ForContext("alpha", 1).Information("metric");

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
