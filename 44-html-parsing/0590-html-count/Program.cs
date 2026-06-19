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

var document = new HtmlParser().ParseDocument(DOC);

// Count how many elements match the CSS class selector ".item".
Console.WriteLine(document.QuerySelectorAll(".item").Length);
