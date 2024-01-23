namespace Bridge.CheckDB;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/CDBServer")]
public partial class CheckTax
{

    private string nameField;

    private double rateField;

    private bool rateFieldSpecified;

    private int taxnumField;

    private bool taxnumFieldSpecified;

    private string ttlField;

    private string txblField;

    private int typeField;

    private bool typeFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 0)]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
    public double rate
    {
        get
        {
            return this.rateField;
        }
        set
        {
            this.rateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool rateSpecified
    {
        get
        {
            return this.rateFieldSpecified;
        }
        set
        {
            this.rateFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
    public int taxnum
    {
        get
        {
            return this.taxnumField;
        }
        set
        {
            this.taxnumField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool taxnumSpecified
    {
        get
        {
            return this.taxnumFieldSpecified;
        }
        set
        {
            this.taxnumFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 3)]
    public string ttl
    {
        get
        {
            return this.ttlField;
        }
        set
        {
            this.ttlField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 4)]
    public string txbl
    {
        get
        {
            return this.txblField;
        }
        set
        {
            this.txblField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
    public int type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool typeSpecified
    {
        get
        {
            return this.typeFieldSpecified;
        }
        set
        {
            this.typeFieldSpecified = value;
        }
    }
}
