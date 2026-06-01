Console.WriteLine($"animal: {new Animal().Speak()}");
Console.WriteLine($"dog: {new Dog().Speak()}");

class Animal
{
    public virtual string Speak() => "some sound";
}

class Dog : Animal
{
    public override string Speak() => "Woof";
}
