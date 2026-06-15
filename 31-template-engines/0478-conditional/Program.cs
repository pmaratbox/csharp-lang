using Scriban;

var t = Template.Parse("{{ if logged_in }}welcome{{ else }}guest{{ end }}");
Console.Write(t.Render(new { logged_in = true }));
Console.WriteLine();
