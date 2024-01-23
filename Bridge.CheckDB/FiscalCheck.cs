namespace Bridge.CheckDB;

[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/CDBServer")]
public partial class FiscalCheck
{

    private string iICField;

    private System.DateTime issueDateTimeField;

    private bool issueDateTimeFieldSpecified;

    private bool adj_checkField;

    private bool adj_checkFieldSpecified;

    private int cashierField;

    private bool cashierFieldSpecified;

    private int cknumField;

    private bool cknumFieldSpecified;

    private System.DateTime close_timeField;

    private bool close_timeFieldSpecified;

    private CheckItem[] dtlField;

    private int grpField;

    private bool grpFieldSpecified;

    private int gstField;

    private bool gstFieldSpecified;

    private System.DateTime open_timeField;

    private bool open_timeFieldSpecified;

    private int rvcField;

    private bool rvcFieldSpecified;

    private CheckTax[] taxField;

    private int tblField;

    private bool tblFieldSpecified;

    private string totalField;

    private bool trans_voidField;

    private bool trans_voidFieldSpecified;

    private int trempField;

    private bool trempFieldSpecified;

    private string tremp_fnameField;

    private string tremp_lnameField;

    private int uwsField;

    private bool uwsFieldSpecified;

    private string waiterField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 0)]
    public string IIC
    {
        get
        {
            return this.iICField;
        }
        set
        {
            this.iICField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
    public System.DateTime IssueDateTime
    {
        get
        {
            return this.issueDateTimeField;
        }
        set
        {
            this.issueDateTimeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool IssueDateTimeSpecified
    {
        get
        {
            return this.issueDateTimeFieldSpecified;
        }
        set
        {
            this.issueDateTimeFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
    public bool adj_check
    {
        get
        {
            return this.adj_checkField;
        }
        set
        {
            this.adj_checkField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool adj_checkSpecified
    {
        get
        {
            return this.adj_checkFieldSpecified;
        }
        set
        {
            this.adj_checkFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
    public int cashier
    {
        get
        {
            return this.cashierField;
        }
        set
        {
            this.cashierField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool cashierSpecified
    {
        get
        {
            return this.cashierFieldSpecified;
        }
        set
        {
            this.cashierFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
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
    [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
    public System.DateTime close_time
    {
        get
        {
            return this.close_timeField;
        }
        set
        {
            this.close_timeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool close_timeSpecified
    {
        get
        {
            return this.close_timeFieldSpecified;
        }
        set
        {
            this.close_timeFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true, Order = 6)]
    public CheckItem[] dtl
    {
        get
        {
            return this.dtlField;
        }
        set
        {
            this.dtlField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
    public int grp
    {
        get
        {
            return this.grpField;
        }
        set
        {
            this.grpField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool grpSpecified
    {
        get
        {
            return this.grpFieldSpecified;
        }
        set
        {
            this.grpFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
    public int gst
    {
        get
        {
            return this.gstField;
        }
        set
        {
            this.gstField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool gstSpecified
    {
        get
        {
            return this.gstFieldSpecified;
        }
        set
        {
            this.gstFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
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
    [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
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

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true, Order = 11)]
    public CheckTax[] tax
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
    [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
    public int tbl
    {
        get
        {
            return this.tblField;
        }
        set
        {
            this.tblField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool tblSpecified
    {
        get
        {
            return this.tblFieldSpecified;
        }
        set
        {
            this.tblFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 13)]
    public string total
    {
        get
        {
            return this.totalField;
        }
        set
        {
            this.totalField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
    public bool trans_void
    {
        get
        {
            return this.trans_voidField;
        }
        set
        {
            this.trans_voidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool trans_voidSpecified
    {
        get
        {
            return this.trans_voidFieldSpecified;
        }
        set
        {
            this.trans_voidFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
    public int tremp
    {
        get
        {
            return this.trempField;
        }
        set
        {
            this.trempField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool trempSpecified
    {
        get
        {
            return this.trempFieldSpecified;
        }
        set
        {
            this.trempFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 16)]
    public string tremp_fname
    {
        get
        {
            return this.tremp_fnameField;
        }
        set
        {
            this.tremp_fnameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 17)]
    public string tremp_lname
    {
        get
        {
            return this.tremp_lnameField;
        }
        set
        {
            this.tremp_lnameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order = 18)]
    public int uws
    {
        get
        {
            return this.uwsField;
        }
        set
        {
            this.uwsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool uwsSpecified
    {
        get
        {
            return this.uwsFieldSpecified;
        }
        set
        {
            this.uwsFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 19)]
    public string waiter
    {
        get
        {
            return this.waiterField;
        }
        set
        {
            this.waiterField = value;
        }
    }
}
