namespace Bridge.CheckDB;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/")]
public partial class ExecuteReaderResponseExecuteReaderResult
{

    private System.Xml.XmlElement[] anyField;

    private System.Xml.XmlElement any1Field;

    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute(Namespace = "http://www.w3.org/2001/XMLSchema", Order = 0)]
    public System.Xml.XmlElement[] Any
    {
        get
        {
            return this.anyField;
        }
        set
        {
            this.anyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute(Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1", Order = 1)]
    public System.Xml.XmlElement Any1
    {
        get
        {
            return this.any1Field;
        }
        set
        {
            this.any1Field = value;
        }
    }
}
