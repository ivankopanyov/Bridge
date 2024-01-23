namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpVisaInvoice
{
    public decimal ExpDataId { get; set; }
    public decimal? ExpViewId { get; set; }
    public string MultiPropertyYn { get; set; }
    public string Resort { get; set; }
    public decimal? ExpInvoiceId { get; set; }
    public decimal? ByNameId { get; set; }
    public decimal? PeNameId { get; set; }
    public decimal? BillNo { get; set; }
    public decimal? InvoiceNo { get; set; }
    public decimal? FolioNo { get; set; }
    public decimal? RoomRate { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? PartyPiId { get; set; }
    public decimal? PartyById { get; set; }
    public decimal? PartySuId { get; set; }
    public decimal? TotalNet { get; set; }
    public decimal? TaxValue { get; set; }
    public decimal? TotalGross { get; set; }
    public string Currency { get; set; }
    public string ConfirmationNo { get; set; }
    public string Room { get; set; }
    public string FolioType { get; set; }
    public DateTime? InsertDate { get; set; }
    public DateTime? Invoicedate { get; set; }
    public DateTime? Arrival { get; set; }
    public DateTime? Departure { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpVisaInvoice>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_VISA_INVOICE");

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.BillNo)
                .HasColumnName("BILL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ByNameId)
                .HasColumnName("BY_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConfirmationNo)
                .HasColumnName("CONFIRMATION_NO")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Currency)
                .HasColumnName("CURRENCY")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExpDataId)
                .HasColumnName("EXP_DATA_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpInvoiceId)
                .HasColumnName("EXP_INVOICE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpViewId)
                .HasColumnName("EXP_VIEW_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioNo)
                .HasColumnName("FOLIO_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioType)
                .HasColumnName("FOLIO_TYPE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InvoiceNo)
                .HasColumnName("INVOICE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Invoicedate)
                .HasColumnName("INVOICEDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MultiPropertyYn)
                .IsRequired()
                .HasColumnName("MULTI_PROPERTY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PartyById)
                .HasColumnName("PARTY_BY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PartyPiId)
                .HasColumnName("PARTY_PI_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PartySuId)
                .HasColumnName("PARTY_SU_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PeNameId)
                .HasColumnName("PE_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RoomRate)
                .HasColumnName("ROOM_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaxValue)
                .HasColumnName("TAX_VALUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalGross)
                .HasColumnName("TOTAL_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalNet)
                .HasColumnName("TOTAL_NET")
                .HasColumnType("NUMBER");
        });
	}
}
