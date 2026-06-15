using FluentValidation;

var result = new V().Validate(new Model { Password = "abcdef" });
var fields = result.Errors
    .Select(e => e.PropertyName.ToLower())
    .Distinct()
    .OrderBy(x => x)
    .ToList();

Console.WriteLine(fields.Count == 0 ? "ok" : string.Join("\n", fields));

public class Model
{
    public string Password { get; set; } = "";
}

public class V : AbstractValidator<Model>
{
    public V()
    {
        RuleFor(x => x.Password).Must(p => p.Any(char.IsDigit));
    }
}
