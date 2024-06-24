namespace Bridge.Services.Control;

public class DescriptionContractResolver : DefaultContractResolver
{
    public DescriptionContractResolver() => NamingStrategy = new CamelCaseNamingStrategy();

    protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
    {
        var property = base.CreateProperty(member, memberSerialization);
        if (member.GetCustomAttribute<DescriptionAttribute>() is DescriptionAttribute attribute
            && !string.IsNullOrWhiteSpace(attribute.Value))
            property.PropertyName += $" ({attribute.Value})";

        return property;
    }

    protected override string ResolvePropertyName(string propertyName) =>
        base.ResolvePropertyName(propertyName).Split(" (")[0];
}
