namespace Bridge.CheckDB;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName = "GetCheckJson", WrapperNamespace = "http://tempuri.org/", IsWrapped = true)]
public partial class GetCheckJsonRequest
{

    [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://tempuri.org/", Order = 0)]
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public string json;

    public GetCheckJsonRequest()
    {
    }

    public GetCheckJsonRequest(string json)
    {
        this.json = json;
    }
}
