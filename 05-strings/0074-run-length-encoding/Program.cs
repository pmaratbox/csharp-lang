var text = "aaabbc";
var result = new System.Text.StringBuilder();
int i = 0;
while (i < text.Length)
{
    char ch = text[i];
    int count = 0;
    while (i < text.Length && text[i] == ch)
    {
        count++;
        i++;
    }
    result.Append(ch).Append(count);
}
Console.WriteLine(result);
