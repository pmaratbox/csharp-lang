var user = new UserId(1);
var product = new ProductId(2);

Console.WriteLine($"{user} {product}");

readonly record struct UserId(int Value)
{
    public override string ToString() => $"user-{Value}";
}

readonly record struct ProductId(int Value)
{
    public override string ToString() => $"prod-{Value}";
}
