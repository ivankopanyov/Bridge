namespace Bridge.Services.Control;

public class ServiceControlSerializerSettings : JsonSerializerSettings
{
    public ServiceControlSerializerSettings() => ContractResolver = new DescriptionContractResolver();
}
