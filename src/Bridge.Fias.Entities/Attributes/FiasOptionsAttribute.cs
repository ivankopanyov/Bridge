namespace Bridge.Fias.Entities.Attributes;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
internal class FiasOptionsAttribute(Type type) : Attribute
{
    public Type Type { get; private set; } = type;
}