using System.Xml.Linq;

var DOC = @"<catalog>
  <book id=""b1"" lang=""en""><title>Go</title><price>30</price></book>
  <book id=""b2"" lang=""fr""><title>Rust</title><price>45</price></book>
</catalog>";

var d = XDocument.Parse(DOC);
var books = d.Root!.Elements("book").ToList();
var titles = books
    .Where(b => b.Attribute("lang")!.Value == "en")
    .Select(b => b.Element("title")!.Value);
Console.WriteLine(string.Join(",", titles));
