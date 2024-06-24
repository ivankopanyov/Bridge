namespace Bridge.Services.Control;

[AttributeUsage(AttributeTargets.Property)]
public class DescriptionAttribute(string value) : Attribute
{
    public string Value { get; private init; } = value;
}

