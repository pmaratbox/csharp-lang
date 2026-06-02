Console.WriteLine(new Calc(5).Add(3).Multiply(2).Result());

class Calc
{
    int value;
    public Calc(int value) { this.value = value; }
    public Calc Add(int n) { value += n; return this; }
    public Calc Multiply(int n) { value *= n; return this; }
    public int Result() => value;
}
