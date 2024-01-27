namespace Bridge.CheckDB;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/CDBServer")]
public partial class CheckItem
{

    private int agentTypeField;

    private bool agentTypeFieldSpecified;

    private string dscField;

    private string excisemarkField;

    private string fgnameField;

    private int fgnumField;

    private bool fgnumFieldSpecified;

    private string mgnameField;

    private int mgnumField;

    private bool mgnumFieldSpecified;

    private string nameField;

    private string name2Field;

    private long objnumField;

    private bool objnumFieldSpecified;

    private double qtfField;

    private bool qtfFieldSpecified;

    private int qtyField;

    private bool qtyFieldSpecified;

    private string refLineField;

    private string supplINNField;

    private string supplNameField;

    private string supplPhoneField;

    private string svcField;

    private byte taxField;

    private bool taxFieldSpecified;

    private int taxpmField;

    private bool taxpmFieldSpecified;

    private int taxpsField;

    private bool taxpsFieldSpecified;

    private string ttlField;

    private int typeField;

    private bool typeFieldSpecified;

    private int unitField;

    private bool unitFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    public int agentType
    {
        get
        {
            return this.agentTypeField;
        }
        set
        {
            this.agentTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool agentTypeSpecified
    {
        get
        {
            return this.agentTypeFieldSpecified;
        }
        set
        {
            this.agentTypeFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 1)]
    public string dsc
    {
        get
        {
            return this.dscField;
        }
        set
        {
            this.dscField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 2)]
    public string excisemark
    {
        get
        {
            return this.excisemarkField;
        }
        set
        {
            this.excisemarkField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 3)]
    public string fgname
    {
        get
        {
            return this.fgnameField;
        }
        set
        {
            this.fgnameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
    public int fgnum
    {
        get
        {
            return this.fgnumField;
        }
        set
        {
            this.fgnumField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool fgnumSpecified
    {
        get
        {
            return this.fgnumFieldSpecified;
        }
        set
        {
            this.fgnumFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 5)]
    public string mgname
    {
        get
        {
            return this.mgnameField;
        }
        set
        {
            this.mgnameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
    public int mgnum
    {
        get
        {
            return this.mgnumField;
        }
        set
        {
            this.mgnumField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool mgnumSpecified
    {
        get
        {
            return this.mgnumFieldSpecified;
        }
        set
        {
            this.mgnumFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 7)]
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
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 8)]
    public string name2
    {
        get
        {
            return this.name2Field;
        }
        set
        {
            this.name2Field = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
    public long objnum
    {
        get
        {
            return this.objnumField;
        }
        set
        {
            this.objnumField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool objnumSpecified
    {
        get
        {
            return this.objnumFieldSpecified;
        }
        set
        {
            this.objnumFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
    public double qtf
    {
        get
        {
            return this.qtfField;
        }
        set
        {
            this.qtfField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool qtfSpecified
    {
        get
        {
            return this.qtfFieldSpecified;
        }
        set
        {
            this.qtfFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
    public int qty
    {
        get
        {
            return this.qtyField;
        }
        set
        {
            this.qtyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool qtySpecified
    {
        get
        {
            return this.qtyFieldSpecified;
        }
        set
        {
            this.qtyFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 12)]
    public string refLine
    {
        get
        {
            return this.refLineField;
        }
        set
        {
            this.refLineField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 13)]
    public string supplINN
    {
        get
        {
            return this.supplINNField;
        }
        set
        {
            this.supplINNField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 14)]
    public string supplName
    {
        get
        {
            return this.supplNameField;
        }
        set
        {
            this.supplNameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 15)]
    public string supplPhone
    {
        get
        {
            return this.supplPhoneField;
        }
        set
        {
            this.supplPhoneField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 16)]
    public string svc
    {
        get
        {
            return this.svcField;
        }
        set
        {
            this.svcField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 17)]
    public byte tax
    {
        get
        {
            return this.taxField;
        }
        set
        {
            this.taxField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool taxSpecified
    {
        get
        {
            return this.taxFieldSpecified;
        }
        set
        {
            this.taxFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 18)]
    public int taxpm
    {
        get
        {
            return this.taxpmField;
        }
        set
        {
            this.taxpmField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool taxpmSpecified
    {
        get
        {
            return this.taxpmFieldSpecified;
        }
        set
        {
            this.taxpmFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 19)]
    public int taxps
    {
        get
        {
            return this.taxpsField;
        }
        set
        {
            this.taxpsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool taxpsSpecified
    {
        get
        {
            return this.taxpsFieldSpecified;
        }
        set
        {
            this.taxpsFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 20)]
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
    [System.Xml.Serialization.XmlElementAttribute(Order = 21)]
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

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 22)]
    public int unit
    {
        get
        {
            return this.unitField;
        }
        set
        {
            this.unitField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool unitSpecified
    {
        get
        {
            return this.unitFieldSpecified;
        }
        set
        {
            this.unitFieldSpecified = value;
        }
    }
}
