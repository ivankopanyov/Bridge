namespace Bridge.DefaultServices;

public class EnumerableRegularExpressionAttribute([StringSyntax(StringSyntaxAttribute.Regex)] string pattern)
    : RegularExpressionAttribute(pattern)
{
    public override bool IsValid(object? value)
    {
        if (value is IDictionary<string, bool> dictionary)
            return Validate(dictionary.Keys);
        
        if (value is IEnumerable<string> enumerable)
            return Validate(enumerable);

        return true;
    }

    private bool Validate(IEnumerable<string> value)
    {
        foreach (string str in value)
            if (str == null || !base.IsValid(str))
                return false;

        return true;
    }
}
