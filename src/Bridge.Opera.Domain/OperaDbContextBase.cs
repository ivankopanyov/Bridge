namespace Bridge.Opera.Domain;

public abstract class OperaDbContextBase : DbContext
{
    private static ISet<Type>? _types;

    private static IEnumerable<MethodInfo>? _methods;

    public OperaDbContextBase() : base() { }

    public OperaDbContextBase(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("OPERA");

        _types ??= GetType().GetProperties()
                .Where(property => property.PropertyType.Name == "DbSet`1" &&
                    property.PropertyType.GenericTypeArguments.Any())
                .Select(property => property.PropertyType.GenericTypeArguments.First())
                .ToHashSet();

        _methods ??= _types
                .SelectMany(type => type.GetMethods()
                    .Where(method => method.Name == nameof(OnModelCreating) &&
                        method.IsStatic &&
                        method.GetParameters().Length == 2 &&
                        method.GetParameters().Any(parameter => parameter.ParameterType == typeof(ModelBuilder)) &&
                        method.GetParameters().Any(parameter => parameter.ParameterType == typeof(ISet<Type>))));

        foreach (var method in _methods)
            method.Invoke(null, new object[] { modelBuilder, _types });
    }
}