var parts = "hello_world".Split('_');
var camel = parts[0] + string.Concat(parts.Skip(1)
    .Select(w => w.Length == 0 ? w : char.ToUpperInvariant(w[0]) + w[1..]));

Console.WriteLine(camel);
