using Scriban;

var template = Template.Parse("{{ name ?? \"anonymous\" }}");
var output = template.Render(new { });
Console.WriteLine(output);
