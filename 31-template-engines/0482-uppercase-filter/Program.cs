using Scriban;

var t = Template.Parse("{{ name | string.upcase }}");
Console.WriteLine(t.Render(new { name = "alice" }));
