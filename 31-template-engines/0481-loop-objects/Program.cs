using Scriban;

var src = "{{ for u in users }}{{ u.name }}: {{ u.age }}{{ if !for.last }}\n{{ end }}{{ end }}";

var template = Template.Parse(src);

var result = template.Render(new
{
    users = new[]
    {
        new { name = "alice", age = 30 },
        new { name = "bob", age = 25 },
    },
});

Console.Write(result);
