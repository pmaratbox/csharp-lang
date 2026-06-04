const string spec = "a-e";
char start = spec[0], end = spec[2];
var sb = new System.Text.StringBuilder();
for (char c = start; c <= end; c++) sb.Append(c);

Console.WriteLine(sb.ToString());
