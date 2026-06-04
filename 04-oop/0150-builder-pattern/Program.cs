var pizza = new PizzaBuilder().SetSize("M").AddTopping("cheese").Build();
Console.WriteLine(pizza);

class Pizza(string size, IReadOnlyList<string> toppings)
{
    public override string ToString() => $"Pizza({size}, {string.Join(", ", toppings)})";
}

class PizzaBuilder
{
    private string size = "M";
    private readonly List<string> toppings = [];

    public PizzaBuilder SetSize(string s) { size = s; return this; }
    public PizzaBuilder AddTopping(string t) { toppings.Add(t); return this; }
    public Pizza Build() => new(size, toppings);
}
