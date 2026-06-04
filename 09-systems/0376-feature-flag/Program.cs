static string Render(bool flag) => flag ? "enabled" : "disabled";

Console.WriteLine($"{Render(true)} {Render(false)}");
