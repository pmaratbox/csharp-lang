using FluentValidation;

var result = new V().Validate(new Model { Email = "not-an-email" });
var fields = result.Errors.Select(e => e.PropertyName.ToLower()).Distinct().OrderBy(x => x);
Console.WriteLine(result.IsValid ? "ok" : string.Join("\n", fields));

public class Model { public string Email { get; set; } = ""; }
public class V : AbstractValidator<Model>
{
    public V()
    {
        ClassLevelCascadeMode = CascadeMode.Continue;
        RuleFor(x => x.Email).EmailAddress();
    }
}
