Console.WriteLine(new WorkAlgorithm().Run());

abstract class Algorithm
{
    public string Run() => $"start {Step()} end";
    protected abstract string Step();
}

sealed class WorkAlgorithm : Algorithm
{
    protected override string Step() => "work";
}
