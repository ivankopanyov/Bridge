namespace Bridge.Fias.Entities;

public abstract class FiasOptions
{
    internal FiasOptions() { }

    public static T All<T>() where T : FiasOptions, new()
    {
        var options = new T();

        var setters = typeof(T)
                .GetProperties()
                .Select(property => property.SetMethod)
                .Where(method => method != null);

        foreach (var setter in setters)
        {
            try
            {
                setter?.Invoke(options, new object[] { true });
            }
            catch
            {
            }
        }

        return options;
    }

    public override int GetHashCode() => GetType().GetHashCode();

    public override bool Equals(object? obj) => obj == null || GetType() == obj.GetType();
}

