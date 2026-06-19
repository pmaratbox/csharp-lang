using Microsoft.Extensions.Configuration;

// Set the env var in-process BEFORE Build(); the environment-variables source
// is added last, so it overrides "name" from config.json.
Environment.SetEnvironmentVariable("name", "from-env");

var cfg = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("config.json")
    .AddEnvironmentVariables()
    .Build();

Console.WriteLine(cfg["name"]);
