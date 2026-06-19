using Microsoft.Extensions.Configuration;

var cfg = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("config.json")
    .AddEnvironmentVariables()
    .Build();

Console.WriteLine(string.Join(",", cfg.GetSection("hosts").Get<string[]>()!));
