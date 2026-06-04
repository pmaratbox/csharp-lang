Console.WriteLine(new Facade().Start());

sealed class Sub1 { public void Init() { } }
sealed class Sub2 { public void Init() { } }
sealed class Sub3 { public void Init() { } }

sealed class Facade
{
    private readonly Sub1 _s1 = new();
    private readonly Sub2 _s2 = new();
    private readonly Sub3 _s3 = new();

    public string Start()
    {
        _s1.Init();
        _s2.Init();
        _s3.Init();
        return "ready";
    }
}
