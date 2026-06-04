string a = "999999999999";
string b = "1";

var result = new System.Text.StringBuilder();
int i = a.Length - 1, j = b.Length - 1, carry = 0;
while (i >= 0 || j >= 0 || carry > 0)
{
    int da = i >= 0 ? a[i--] - '0' : 0;
    int db = j >= 0 ? b[j--] - '0' : 0;
    int sum = da + db + carry;
    carry = sum / 10;
    result.Insert(0, (char)('0' + sum % 10));
}

Console.WriteLine(result.ToString());
