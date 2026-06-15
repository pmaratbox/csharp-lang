using Scriban;

var t = Template.Parse("{{ user.name }}");
Console.WriteLine(t.Render(new { user = new { name = "alice" } }));
