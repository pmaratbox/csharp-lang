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

// Select the element with id `status` using the CSS id selector `#status`.
Console.WriteLine(document.QuerySelector("#status")!.TextContent);
