namespace Bridge.CheckDB;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName = "ExecuteReaderResponse", WrapperNamespace = "http://tempuri.org/", IsWrapped = true)]
public partial class ExecuteReaderResponse
{

    [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://tempuri.org/", Order = 0)]
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public ExecuteReaderResponseExecuteReaderResult ExecuteReaderResult;

    public ExecuteReaderResponse()
    {
    }

    public ExecuteReaderResponse(ExecuteReaderResponseExecuteReaderResult ExecuteReaderResult)
    {
        this.ExecuteReaderResult = ExecuteReaderResult;
    }
}
