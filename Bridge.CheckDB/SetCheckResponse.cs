namespace Bridge.CheckDB;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName = "SetCheckResponse", WrapperNamespace = "http://tempuri.org/", IsWrapped = true)]
public partial class SetCheckResponse
{

    [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://tempuri.org/", Order = 0)]
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public Response SetCheckResult;

    public SetCheckResponse()
    {
    }

    public SetCheckResponse(Response SetCheckResult)
    {
        this.SetCheckResult = SetCheckResult;
    }
}
