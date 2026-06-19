using Markdig;

string Render(string src) => Markdown.ToHtml(src).TrimEnd('\n');

Console.WriteLine(Render("# Hello"));
