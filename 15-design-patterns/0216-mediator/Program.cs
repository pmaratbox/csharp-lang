var mediator = new Mediator();
var a = new Colleague("A", mediator);
var b = new Colleague("B", mediator);
mediator.A = a;
mediator.B = b;
a.Send("hi");

sealed class Mediator
{
    public Colleague? A { get; set; }
    public Colleague? B { get; set; }

    public void Route(Colleague sender, string message)
    {
        var target = sender == A ? B : A;
        target?.Receive(message);
    }
}

sealed class Colleague
{
    private readonly string _name;
    private readonly Mediator _mediator;
    public Colleague(string name, Mediator mediator)
    {
        _name = name;
        _mediator = mediator;
    }
    public void Send(string message) => _mediator.Route(this, message);
    public void Receive(string message) => Console.WriteLine($"{_name} got: {message}");
}
