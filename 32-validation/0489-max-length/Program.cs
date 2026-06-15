using FluentValidation;

var result = new V().Validate(new Model { Code = "ABCDEFG" });
var fields = result.Errors
    .Select(e => e.PropertyName.ToLower())
    .Distinct()
    .OrderBy(x => x)
    .ToList();

Console.WriteLine(fields.Count == 0 ? "ok" : string.Join("\n", fields));

public class Model
{
    public string Code { get; set; } = "";
}

public class V : AbstractValidator<Model>
{
    public V()
    {
        RuleFor(x => x.Code).MaximumLength(5);
    }
}
