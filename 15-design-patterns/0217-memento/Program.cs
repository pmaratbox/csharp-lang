var originator = new Originator { State = 1 };
var saved = originator.Save();
originator.State = 2;
Console.Write(originator.State);
originator.Restore(saved);
Console.WriteLine($" {originator.State}");

sealed record Memento(int State);

sealed class Originator
{
    public int State { get; set; }
    public Memento Save() => new(State);
    public void Restore(Memento memento) => State = memento.State;
}
