namespace Bridge.Services.Control;

public abstract class Options
{
    public Options() { }

    public Options(ServiceOptions serviceOptions)
    {
        foreach (var property in GetType().GetProperties())
        { 
            if (property.SetMethod is not MethodInfo setMethod || !setMethod.IsPublic || property.GetMethod is not MethodInfo getMethod || !getMethod.IsPublic)
                continue;

            if (property.PropertyType == typeof(string) && serviceOptions.Properties
                .FirstOrDefault(p => p.Type == ServicePropertyType.String && property.Name == GetName(p.Name)) is ServiceProperty stringServiceProperty)
                property.SetValue(this, stringServiceProperty.Value);
            if (property.PropertyType == typeof(string) && serviceOptions.Properties
                .FirstOrDefault(p => p.Type == ServicePropertyType.Int && property.Name == GetName(p.Name)) is ServiceProperty intServiceProperty
                && int.TryParse(intServiceProperty.Value, out int result))
                property.SetValue(this, result);
            else if (property.PropertyType.IsAssignableFrom(typeof(IEnumerable<string>)) && serviceOptions.RepeatedProperties
                .FirstOrDefault(p => property.Name == GetName(p.Name)) is RepeatedServiceProperty repeatedServiceProperty)
                property.SetValue(this, repeatedServiceProperty.Value);
            else if (property.PropertyType.IsAssignableFrom(typeof(IDictionary<string, string>)) && serviceOptions.MapProperties
                .FirstOrDefault(p => property.Name == GetName(p.Name)) is MapServiceProperty mapServiceProperty)
                property.SetValue(this, mapServiceProperty.Value);
        }
    }

    public ServiceOptions ToServiceOptions()
    {
        var serviceOptions = new ServiceOptions();

        foreach (var property in GetType().GetProperties())
        {
            if (property.SetMethod is not MethodInfo setMethod || !setMethod.IsPublic || property.GetMethod is not MethodInfo getMethod || !getMethod.IsPublic)
                continue;

            if (property.PropertyType == typeof(string))
                serviceOptions.Properties.Add(new ServiceProperty
                {
                    Name = GetDisplayName(property.Name),
                    Value = property.GetValue(this)?.ToString() ?? string.Empty,
                    Type = ServicePropertyType.String
                }); 
            else if (property.PropertyType == typeof(int))
                serviceOptions.Properties.Add(new ServiceProperty
                {
                    Name = GetDisplayName(property.Name),
                    Value = property.GetValue(this)?.ToString() ?? string.Empty,
                    Type = ServicePropertyType.Int
                });
            else if (property.PropertyType.IsAssignableFrom(typeof(IEnumerable<string>)) && property.GetValue(this) is IEnumerable<string> repeatedStringPropertyValue)
            {
                var repeatedServiceProperty = new RepeatedServiceProperty
                {
                    Name = GetDisplayName(property.Name)
                };

                repeatedServiceProperty.Value.AddRange(repeatedStringPropertyValue.Where(p => p != null));
                serviceOptions.RepeatedProperties.Add(repeatedServiceProperty);
            }
            else if (property.PropertyType.IsAssignableFrom(typeof(IDictionary<string, string>)) && property.GetValue(this) is IDictionary<string, string> mapPropertyValue)
            {
                var mapServiceProperty = new MapServiceProperty
                {
                    Name = GetDisplayName(property.Name)
                };

                foreach (var value in mapPropertyValue)
                    if (value.Key != null)
                        mapServiceProperty.Value.TryAdd(value.Key, value.Value ?? string.Empty);

                serviceOptions.MapProperties.Add(mapServiceProperty);
            }
        }

        return serviceOptions;
    }

    private static string GetDisplayName(string name)
    {
        var words = Regex.Matches(name, @"([A-Z][a-z]+)")
            .Cast<Match>()
            .Select(m => m.Value);

        return string.Join(" ", words);
    }

    private static string? GetName(string name) => name?.Replace(" ", "");
}
