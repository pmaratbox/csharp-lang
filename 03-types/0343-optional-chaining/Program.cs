var present = new A(new B(new C(5)));
var absent = new A(new B(null));

Console.WriteLine($"{Read(present)} {Read(absent)}");

static int Read(A? a) => a?.B?.C?.Value ?? 0;

record C(int Value);
record B(C? C);
record A(B? B);
