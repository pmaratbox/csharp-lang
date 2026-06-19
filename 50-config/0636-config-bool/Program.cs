using Microsoft.Extensions.Configuration;

var cfg = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("config.json")
    .AddEnvironmentVariables()
    .Build();

Console.WriteLine(cfg.GetValue<bool>("debug").ToString().ToLower());
