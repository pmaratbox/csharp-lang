// 1+2*3 -> Add(1, Mul(2,3))
Expr ast = new Add(new Num(1), new Mul(new Num(2), new Num(3)));
Console.WriteLine(ast.Eval());

abstract record Expr
{
    public abstract int Eval();
}

record Num(int Value) : Expr
{
    public override int Eval() => Value;
}

record Add(Expr Left, Expr Right) : Expr
{
    public override int Eval() => Left.Eval() + Right.Eval();
}

record Mul(Expr Left, Expr Right) : Expr
{
    public override int Eval() => Left.Eval() * Right.Eval();
}
