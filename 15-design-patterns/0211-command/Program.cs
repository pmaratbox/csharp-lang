var counter = new Counter();
ICommand cmd = new AddCommand(counter, 5);
cmd.Execute();
Console.Write(counter.Value);
cmd.Undo();
Console.WriteLine($" {counter.Value}");

sealed class Counter { public int Value; }

interface ICommand
{
    void Execute();
    void Undo();
}

sealed class AddCommand : ICommand
{
    private readonly Counter _counter;
    private readonly int _amount;
    public AddCommand(Counter counter, int amount)
    {
        _counter = counter;
        _amount = amount;
    }
    public void Execute() => _counter.Value += _amount;
    public void Undo() => _counter.Value -= _amount;
}
