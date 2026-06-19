using AngleSharp.Html.Parser;

var DOC = @"<html><body>
<h1>Hello</h1>
<span id=""status"">active</span>
<ul class=""items"">
<li class=""item"">apple</li>
<li class=""item"">banana</li>
<li class=""item"">cherry</li>
</ul>
<a href=""https://example.com"">site</a>
<div class=""content""><p>first</p><p>second</p></div>
</body></html>";

var d = new HtmlParser().ParseDocument(DOC);

// Descendant selector: select <p> elements nested inside .content,
// take each one's text, and join with commas.
var paragraphs = d.QuerySelectorAll(".content p").Select(e => e.TextContent);
Console.WriteLine(string.Join(",", paragraphs));
