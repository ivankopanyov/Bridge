namespace Bridge.Fias.Entities.Base;

public abstract class FiasMessageToPms : FiasMessageBase
{
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        => Enumerable.Empty<ValidationResult>();
}