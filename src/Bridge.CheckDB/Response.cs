namespace Bridge.CheckDB;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/CDBServer")]
public partial class Response
{

    private FiscalCheck checkField;

    private string errtextField;

    private long idField;

    private bool idFieldSpecified;

    private bool successField;

    private bool successFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 0)]
    public FiscalCheck check
    {
        get
        {
            return this.checkField;
        }
        set
        {
            this.checkField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 1)]
    public string errtext
    {
        get
        {
            return this.errtextField;
        }
        set
        {
            this.errtextField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
    public long id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool idSpecified
    {
        get
        {
            return this.idFieldSpecified;
        }
        set
        {
            this.idFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
    public bool success
    {
        get
        {
            return this.successField;
        }
        set
        {
            this.successField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool successSpecified
    {
        get
        {
            return this.successFieldSpecified;
        }
        set
        {
            this.successFieldSpecified = value;
        }
    }
}
