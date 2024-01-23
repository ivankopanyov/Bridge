namespace Bridge.CheckDB;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/CDBServer")]
public partial class Request
{

    private int cknumField;

    private bool cknumFieldSpecified;

    private long idField;

    private bool idFieldSpecified;

    private System.DateTime open_timeField;

    private bool open_timeFieldSpecified;

    private int rvcField;

    private bool rvcFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public int cknum
    {
        get
        {
            return this.cknumField;
        }
        set
        {
            this.cknumField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool cknumSpecified
    {
        get
        {
            return this.cknumFieldSpecified;
        }
        set
        {
            this.cknumFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
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
    [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
    public System.DateTime open_time
    {
        get
        {
            return this.open_timeField;
        }
        set
        {
            this.open_timeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool open_timeSpecified
    {
        get
        {
            return this.open_timeFieldSpecified;
        }
        set
        {
            this.open_timeFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
    public int rvc
    {
        get
        {
            return this.rvcField;
        }
        set
        {
            this.rvcField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool rvcSpecified
    {
        get
        {
            return this.rvcFieldSpecified;
        }
        set
        {
            this.rvcFieldSpecified = value;
        }
    }
}
