using Microsoft.Extensions.Configuration;

var cfg = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("config.json")
    .AddEnvironmentVariables()
    .Build();

// Nested keys use ':' as the separator, so server.port -> "server:port".
Console.WriteLine(cfg.GetValue<int>("server:port"));
