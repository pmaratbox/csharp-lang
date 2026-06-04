IThemeFactory factory = new DarkThemeFactory();
var button = factory.CreateButton();
var checkbox = factory.CreateCheckbox();
Console.WriteLine($"{button.Label} {checkbox.Label}");

interface IButton { string Label { get; } }
interface ICheckbox { string Label { get; } }

interface IThemeFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}

sealed class DarkButton : IButton { public string Label => "dark-button"; }
sealed class DarkCheckbox : ICheckbox { public string Label => "dark-checkbox"; }

sealed class DarkThemeFactory : IThemeFactory
{
    public IButton CreateButton() => new DarkButton();
    public ICheckbox CreateCheckbox() => new DarkCheckbox();
}
