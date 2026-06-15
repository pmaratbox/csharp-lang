using FluentValidation;

// Input has name present but age MISSING (null).
var result = new V().Validate(new Model { Name = "alice", Age = null });

if (result.IsValid)
{
    Console.WriteLine("ok");
}
else
{
    var fields = result.Errors
        .Select(e => e.PropertyName.ToLower())
        .Distinct()
        .OrderBy(x => x);
    Console.WriteLine(string.Join("\n", fields));
}

public class Model
{
    public string? Name { get; set; }
    public int? Age { get; set; }
}

public class V : AbstractValidator<Model>
{
    public V()
    {
        // Report all failures, not just the first.
        RuleFor(x => x.Name).NotNull().MinimumLength(3);
        RuleFor(x => x.Age).NotNull().InclusiveBetween(0, 120);
    }
}
