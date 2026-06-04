_ = new Widget();
_ = new Widget();
_ = new Widget();
Console.WriteLine(Widget.Count);

class Widget
{
    public static int Count { get; private set; }

    public Widget() => Count++;
}
