using FluentValidation;

var result = new V().Validate(new Model { Name = "alice", Age = 200 });
var fields = result.Errors.Select(e => e.PropertyName.ToLower()).Distinct().OrderBy(x => x).ToList();
Console.WriteLine(fields.Count == 0 ? "ok" : string.Join("\n", fields));

public class Model { public string Name { get; set; } = ""; public int Age { get; set; } }
public class V : AbstractValidator<Model>
{
    public V()
    {
        RuleLevelCascadeMode = CascadeMode.Continue;
        RuleFor(x => x.Name).MinimumLength(3);
        RuleFor(x => x.Age).InclusiveBetween(0, 120);
    }
}
