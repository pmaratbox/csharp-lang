using FluentValidation;

var result = new MultipleErrorsValidator().Validate(new Model { Name = "al", Age = 200 });

var fields = result.Errors
    .Select(e => e.PropertyName.ToLower())
    .Distinct()
    .OrderBy(x => x);

Console.WriteLine(result.IsValid ? "ok" : string.Join("\n", fields));

public class Model
{
    public string Name { get; set; } = "";
    public int Age { get; set; }
}

public class MultipleErrorsValidator : AbstractValidator<Model>
{
    public MultipleErrorsValidator()
    {
        // Report every failing rule, not just the first one.
        ClassLevelCascadeMode = CascadeMode.Continue;
        RuleLevelCascadeMode = CascadeMode.Continue;

        RuleFor(x => x.Name).MinimumLength(3);
        RuleFor(x => x.Age).InclusiveBetween(0, 120);
    }
}
