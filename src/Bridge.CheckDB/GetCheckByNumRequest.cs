namespace Bridge.CheckDB;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName = "GetCheckByNum", WrapperNamespace = "http://tempuri.org/", IsWrapped = true)]
public partial class GetCheckByNumRequest
{

    [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://tempuri.org/", Order = 0)]
    public int rvc;

    [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://tempuri.org/", Order = 1)]
    public int cknum;

    [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://tempuri.org/", Order = 2)]
    public System.DateTime ckopen;

    public GetCheckByNumRequest()
    {
    }

    public GetCheckByNumRequest(int rvc, int cknum, System.DateTime ckopen)
    {
        this.rvc = rvc;
        this.cknum = cknum;
        this.ckopen = ckopen;
    }
}
