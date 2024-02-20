namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class PortelPayloadView
{
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? BillNo { get; set; }
    public decimal? FolioNo { get; set; }
    public DateTime? BillGenerationDate { get; set; }
    public decimal? NameId { get; set; }
    public decimal? Intid { get; set; }
    public string? Invoiceid { get; set; }
    public string? Invoiceno { get; set; }
    public string? Description { get; set; }
    public string? Invoicedate { get; set; }
    public decimal? Invoicetype { get; set; }
    public decimal? Scenariotype { get; set; }
    public string? Orderno { get; set; }
    public string? Dispatchno { get; set; }
    public decimal? Foliono1 { get; set; }
    public decimal? Totalamount { get; set; }
    public decimal? Totalpayamount { get; set; }
    public string? Currencycode { get; set; }
    public decimal? Discountamount { get; set; }
    public decimal? Taxableamount { get; set; }
    public decimal? Roundingamount { get; set; }
    public decimal? Taxamount { get; set; }
    public decimal? Withholdingtax { get; set; }
    public decimal? Taxexemption { get; set; }
    public decimal? Folderintid { get; set; }
    public string? Envelopeno { get; set; }
    public decimal? Invoicestatus { get; set; }
    public string? Externaltrackno { get; set; }
    public decimal? Direction { get; set; }
    public string? Dontshow { get; set; }
    public string? Createdon { get; set; }
    public decimal? Createdby { get; set; }
    public string? Modifiedon { get; set; }
    public decimal? Modifiedby { get; set; }
    public string? Errormessage { get; set; }
    public decimal? Sourceintid { get; set; }
    public decimal? Gibstatuscode { get; set; }
    public string? Gibstatus { get; set; }
    public decimal? Integratorsourceintid { get; set; }
    public decimal? Customerid { get; set; }
    public string? Customername { get; set; }
    public string? Customertaxoffice { get; set; }
    public string? Customertaxno { get; set; }
    public string? Customerwebsite { get; set; }
    public string? Customeremail { get; set; }
    public string? Customertel { get; set; }
    public string? Customerfax { get; set; }
    public string? Customerroom { get; set; }
    public string? Customerstreetname { get; set; }
    public string? Customerbuildingname { get; set; }
    public string? Customerbuildingnumber { get; set; }
    public string? Customercitysubdivisionname { get; set; }
    public string? Customercityname { get; set; }
    public string? Customerpostalzone { get; set; }
    public string? Customercountryname { get; set; }
    public decimal? Supplierintid { get; set; }
    public decimal? Supplierid { get; set; }
    public string? Suppliername { get; set; }
    public string? Suppliertaxoffice { get; set; }
    public string? Suppliertaxno { get; set; }
    public string? Supplierwebsite { get; set; }
    public string? Supplieremail { get; set; }
    public string? Suppliertel { get; set; }
    public string? Supplierfax { get; set; }
    public string? Supplierroom { get; set; }
    public string? Supplierstreetname { get; set; }
    public string? Supplierbuildingname { get; set; }
    public string? Supplierbuildingnumber { get; set; }
    public string? Suppliercitysubdivisionname { get; set; }
    public string? Suppliercityname { get; set; }
    public string? Supplierpostalzone { get; set; }
    public string? Suppliercountryname { get; set; }
    public string? Invoicelines { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PortelPayloadView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PORTEL_PAYLOAD_VIEW");

            entity.Property(e => e.BillGenerationDate)
                .HasColumnName("BILL_GENERATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BillNo)
                .HasColumnName("BILL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Createdby)
                .HasColumnName("CREATEDBY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Createdon)
                .HasColumnName("CREATEDON")
                .IsUnicode(false);

            entity.Property(e => e.Currencycode)
                .HasColumnName("CURRENCYCODE")
                .HasColumnType("CHAR(3)");

            entity.Property(e => e.Customerbuildingname)
                .HasColumnName("CUSTOMERBUILDINGNAME")
                .IsUnicode(false);

            entity.Property(e => e.Customerbuildingnumber)
                .HasColumnName("CUSTOMERBUILDINGNUMBER")
                .IsUnicode(false);

            entity.Property(e => e.Customercityname)
                .HasColumnName("CUSTOMERCITYNAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Customercitysubdivisionname)
                .HasColumnName("CUSTOMERCITYSUBDIVISIONNAME")
                .IsUnicode(false);

            entity.Property(e => e.Customercountryname)
                .HasColumnName("CUSTOMERCOUNTRYNAME")
                .IsUnicode(false);

            entity.Property(e => e.Customeremail)
                .HasColumnName("CUSTOMEREMAIL")
                .IsUnicode(false);

            entity.Property(e => e.Customerfax)
                .HasColumnName("CUSTOMERFAX")
                .IsUnicode(false);

            entity.Property(e => e.Customerid)
                .HasColumnName("CUSTOMERID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Customername)
                .HasColumnName("CUSTOMERNAME")
                .IsUnicode(false);

            entity.Property(e => e.Customerpostalzone)
                .HasColumnName("CUSTOMERPOSTALZONE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.Customerroom)
                .HasColumnName("CUSTOMERROOM")
                .IsUnicode(false);

            entity.Property(e => e.Customerstreetname)
                .HasColumnName("CUSTOMERSTREETNAME")
                .HasMaxLength(323)
                .IsUnicode(false);

            entity.Property(e => e.Customertaxno)
                .HasColumnName("CUSTOMERTAXNO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Customertaxoffice)
                .HasColumnName("CUSTOMERTAXOFFICE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Customertel)
                .HasColumnName("CUSTOMERTEL")
                .IsUnicode(false);

            entity.Property(e => e.Customerwebsite)
                .HasColumnName("CUSTOMERWEBSITE")
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.Direction)
                .HasColumnName("DIRECTION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Discountamount)
                .HasColumnName("DISCOUNTAMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Dispatchno)
                .HasColumnName("DISPATCHNO")
                .IsUnicode(false);

            entity.Property(e => e.Dontshow)
                .HasColumnName("DONTSHOW")
                .IsUnicode(false);

            entity.Property(e => e.Envelopeno)
                .HasColumnName("ENVELOPENO")
                .IsUnicode(false);

            entity.Property(e => e.Errormessage)
                .HasColumnName("ERRORMESSAGE")
                .IsUnicode(false);

            entity.Property(e => e.Externaltrackno)
                .HasColumnName("EXTERNALTRACKNO")
                .IsUnicode(false);

            entity.Property(e => e.Folderintid)
                .HasColumnName("FOLDERINTID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioNo)
                .HasColumnName("FOLIO_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Foliono1)
                .HasColumnName("FOLIONO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Gibstatus)
                .HasColumnName("GIBSTATUS")
                .IsUnicode(false);

            entity.Property(e => e.Gibstatuscode)
                .HasColumnName("GIBSTATUSCODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Integratorsourceintid)
                .HasColumnName("INTEGRATORSOURCEINTID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Intid)
                .HasColumnName("INTID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Invoicedate)
                .HasColumnName("INVOICEDATE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Invoiceid)
                .HasColumnName("INVOICEID")
                .HasMaxLength(46)
                .IsUnicode(false);

            entity.Property(e => e.Invoicelines)
                .HasColumnName("INVOICELINES")
                .IsUnicode(false);

            entity.Property(e => e.Invoiceno)
                .HasColumnName("INVOICENO")
                .IsUnicode(false);

            entity.Property(e => e.Invoicestatus)
                .HasColumnName("INVOICESTATUS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Invoicetype)
                .HasColumnName("INVOICETYPE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Modifiedby)
                .HasColumnName("MODIFIEDBY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Modifiedon)
                .HasColumnName("MODIFIEDON")
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Orderno)
                .HasColumnName("ORDERNO")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Roundingamount)
                .HasColumnName("ROUNDINGAMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Scenariotype)
                .HasColumnName("SCENARIOTYPE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Sourceintid)
                .HasColumnName("SOURCEINTID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Supplierbuildingname)
                .HasColumnName("SUPPLIERBUILDINGNAME")
                .IsUnicode(false);

            entity.Property(e => e.Supplierbuildingnumber)
                .HasColumnName("SUPPLIERBUILDINGNUMBER")
                .IsUnicode(false);

            entity.Property(e => e.Suppliercityname)
                .HasColumnName("SUPPLIERCITYNAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Suppliercitysubdivisionname)
                .HasColumnName("SUPPLIERCITYSUBDIVISIONNAME")
                .IsUnicode(false);

            entity.Property(e => e.Suppliercountryname)
                .HasColumnName("SUPPLIERCOUNTRYNAME")
                .IsUnicode(false);

            entity.Property(e => e.Supplieremail)
                .HasColumnName("SUPPLIEREMAIL")
                .IsUnicode(false);

            entity.Property(e => e.Supplierfax)
                .HasColumnName("SUPPLIERFAX")
                .IsUnicode(false);

            entity.Property(e => e.Supplierid)
                .HasColumnName("SUPPLIERID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Supplierintid)
                .HasColumnName("SUPPLIERINTID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Suppliername)
                .HasColumnName("SUPPLIERNAME")
                .IsUnicode(false);

            entity.Property(e => e.Supplierpostalzone)
                .HasColumnName("SUPPLIERPOSTALZONE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.Supplierroom)
                .HasColumnName("SUPPLIERROOM")
                .IsUnicode(false);

            entity.Property(e => e.Supplierstreetname)
                .HasColumnName("SUPPLIERSTREETNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Suppliertaxno)
                .HasColumnName("SUPPLIERTAXNO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Suppliertaxoffice)
                .HasColumnName("SUPPLIERTAXOFFICE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Suppliertel)
                .HasColumnName("SUPPLIERTEL")
                .IsUnicode(false);

            entity.Property(e => e.Supplierwebsite)
                .HasColumnName("SUPPLIERWEBSITE")
                .IsUnicode(false);

            entity.Property(e => e.Taxableamount)
                .HasColumnName("TAXABLEAMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Taxamount)
                .HasColumnName("TAXAMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Taxexemption)
                .HasColumnName("TAXEXEMPTION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Totalamount)
                .HasColumnName("TOTALAMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Totalpayamount)
                .HasColumnName("TOTALPAYAMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Withholdingtax)
                .HasColumnName("WITHHOLDINGTAX")
                .HasColumnType("NUMBER");
        });
	}
}
