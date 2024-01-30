namespace Bridge.Opera.Domain.Entities.Tables;

public partial class FolioPurgeHistory
{
    public string? Resort { get; set; }
    public DateTime? PurgeDate { get; set; }
    public string? RecordType { get; set; }
    public decimal? FolioNo { get; set; }
    public decimal? BillNo { get; set; }
    public decimal? InvoiceNo { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? Room { get; set; }
    public decimal? NameId { get; set; }
    public string? LastName { get; set; }
    public string? FirstName { get; set; }
    public decimal? Window { get; set; }
    public decimal? DebitAmt { get; set; }
    public DateTime? Arrival { get; set; }
    public DateTime? Departure { get; set; }
    public string? FolioPdfName { get; set; }
    public string? PayeeName { get; set; }
    public decimal? TravelAgentId { get; set; }
    public decimal? SourceId { get; set; }
    public decimal? CompanyId { get; set; }
    public string? ActionName { get; set; }
    public decimal? FolioAttachmentLinkId { get; set; }
    public decimal? FolioAttachmentStatus { get; set; }
    public decimal? AddresseeNameId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FolioPurgeHistory>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("FOLIO_PURGE_HISTORY");

            entity.HasIndex(e => new { e.Resort, e.Arrival })
                .HasName("FOLIO_PURGE_HIST_IND3");

            entity.HasIndex(e => new { e.Resort, e.Departure })
                .HasName("FOLIO_PURGE_HIST_IND1");

            entity.HasIndex(e => new { e.Resort, e.PurgeDate })
                .HasName("FOLIO_PURGE_HIST_IND2");

            entity.Property(e => e.ActionName)
                .HasColumnName("ACTION_NAME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AddresseeNameId)
                .HasColumnName("ADDRESSEE_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.BillNo)
                .HasColumnName("BILL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyId)
                .HasColumnName("COMPANY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DebitAmt)
                .HasColumnName("DEBIT_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.FirstName)
                .HasColumnName("FIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FolioAttachmentLinkId)
                .HasColumnName("FOLIO_ATTACHMENT_LINK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioAttachmentStatus)
                .HasColumnName("FOLIO_ATTACHMENT_STATUS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioNo)
                .HasColumnName("FOLIO_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioPdfName)
                .IsRequired()
                .HasColumnName("FOLIO_PDF_NAME")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.InvoiceNo)
                .HasColumnName("INVOICE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastName)
                .HasColumnName("LAST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PayeeName)
                .HasColumnName("PAYEE_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PurgeDate)
                .HasColumnName("PURGE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceId)
                .HasColumnName("SOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TravelAgentId)
                .HasColumnName("TRAVEL_AGENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Window)
                .HasColumnName("WINDOW")
                .HasColumnType("NUMBER");
        });
	}
}
