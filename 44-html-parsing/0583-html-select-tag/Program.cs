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

// Select the <h1> element with a type selector and print its text.
Console.WriteLine(d.QuerySelector("h1")!.TextContent);
