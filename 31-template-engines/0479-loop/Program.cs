using Scriban;

var src = "{{ for n in nums }}{{ n }}{{ if !for.last }}\n{{ end }}{{ end }}";
var t = Template.Parse(src);
Console.WriteLine(t.Render(new { nums = new[] { 1, 2, 3 } }));
