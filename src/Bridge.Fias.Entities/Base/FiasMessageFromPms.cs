namespace Bridge.Fias.Entities.Base;

public abstract class FiasMessageFromPms : FiasMessageBase
{
    public sealed override IEnumerable<ValidationResult> Validate(ValidationContext validationContext) =>
        new List<ValidationResult>() { 
            new( $"The {GetType().Name} message type is not one of the message types sent to the PMS.")
        };
}

