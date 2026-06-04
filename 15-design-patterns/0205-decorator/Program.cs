ICoffee coffee = new Sugar(new Milk(new BaseCoffee()));
Console.WriteLine(coffee.Cost());

interface ICoffee { int Cost(); }

sealed class BaseCoffee : ICoffee { public int Cost() => 2; }

abstract class CoffeeDecorator : ICoffee
{
    protected readonly ICoffee Inner;
    protected CoffeeDecorator(ICoffee inner) => Inner = inner;
    public abstract int Cost();
}

sealed class Milk : CoffeeDecorator
{
    public Milk(ICoffee inner) : base(inner) { }
    public override int Cost() => Inner.Cost() + 1;
}

sealed class Sugar : CoffeeDecorator
{
    public Sugar(ICoffee inner) : base(inner) { }
    public override int Cost() => Inner.Cost() + 1;
}
