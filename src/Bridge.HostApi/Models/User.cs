namespace Bridge.HostApi.Models;

public class User : IdentityUser<long>
{
    public bool CanModified { get; set; } = true;
}
