using Microsoft.Extensions.Configuration;

var cfg = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("config.json")
    .AddEnvironmentVariables()
    .Build();

// Read two keys from the "server" section and combine them. Nested keys use
// ':' as the separator, so server.host -> "server:host", server.port -> "server:port".
Console.WriteLine($"{cfg["server:host"]}:{cfg["server:port"]}");
