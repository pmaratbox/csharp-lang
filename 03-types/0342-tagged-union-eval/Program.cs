Expr expr = new Add(new Num(1), new Num(2));
Console.WriteLine(Eval(expr));

static int Eval(Expr e) => e switch
{
    Num n => n.Value,
    Add a => Eval(a.Left) + Eval(a.Right),
    _ => throw new InvalidOperationException(),
};

abstract record Expr;
record Num(int Value) : Expr;
record Add(Expr Left, Expr Right) : Expr;
