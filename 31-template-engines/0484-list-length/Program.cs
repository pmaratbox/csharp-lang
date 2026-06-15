using Scriban;

var src = "{{ items.size }}";

var template = Template.Parse(src);

var result = template.Render(new
{
    items = new[] { 1, 2, 3 },
});

Console.Write(result);
