using Scriban;

var t = Template.Parse("Hello {{ name }}");
Console.WriteLine(t.Render(new { name = "alice" }));
