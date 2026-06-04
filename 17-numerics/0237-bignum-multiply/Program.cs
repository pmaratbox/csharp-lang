string a = "123";
string b = "456";

int[] product = new int[a.Length + b.Length];
for (int i = a.Length - 1; i >= 0; i--)
{
    for (int j = b.Length - 1; j >= 0; j--)
    {
        int mul = (a[i] - '0') * (b[j] - '0');
        int pos = i + j + 1;
        int sum = mul + product[pos];
        product[pos] = sum % 10;
        product[i + j] += sum / 10;
    }
}

var sb = new System.Text.StringBuilder();
foreach (int d in product)
{
    if (sb.Length == 0 && d == 0) continue;
    sb.Append((char)('0' + d));
}

Console.WriteLine(sb.Length == 0 ? "0" : sb.ToString());
