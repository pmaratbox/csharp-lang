var row = "a,\"b,c\",d";
var fields = new List<string>();
var sb = new System.Text.StringBuilder();
var inQuotes = false;
foreach (var ch in row)
{
    if (ch == '"') inQuotes = !inQuotes;
    else if (ch == ',' && !inQuotes)
    {
        fields.Add(sb.ToString());
        sb.Clear();
    }
    else sb.Append(ch);
}
fields.Add(sb.ToString());
Console.WriteLine(string.Join('|', fields));
