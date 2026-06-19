using AngleSharp.Html.Parser;

var DOC = "<table><tr><td>r1c1</td><td>r1c2</td></tr><tr><td>r2c1</td><td>r2c2</td></tr></table>";

var d = new HtmlParser().ParseDocument(DOC);

// Select every <td> cell with a type selector; QuerySelectorAll yields them
// in document (row-major) order, so joining their text reads across each row.
Console.WriteLine(string.Join(",", d.QuerySelectorAll("td").Select(e => e.TextContent)));
