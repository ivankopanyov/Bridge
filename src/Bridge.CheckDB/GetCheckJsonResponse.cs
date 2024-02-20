namespace Bridge.CheckDB;

public partial class GetCheckJsonResponse
{

    [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://tempuri.org/", Order = 0)]
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public string GetCheckJsonResult;

    public GetCheckJsonResponse()
    {
    }

    public GetCheckJsonResponse(string GetCheckJsonResult)
    {
        this.GetCheckJsonResult = GetCheckJsonResult;
    }
}
