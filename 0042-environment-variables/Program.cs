string value = Environment.GetEnvironmentVariable("LESSON_ENV_VAR") ?? "default";
Console.WriteLine($"value: {value}");
