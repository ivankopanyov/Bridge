namespace Bridge.Fias.Entities;

public partial class FiasLinkAlive : FiasMessageToPms
{
    /// <summary>
    /// <b>Required..</b><br/>
    /// <b>Обязательно.</b>
    /// </summary>
    [Required]
    public DateTime DateTime { get; set; }
}
