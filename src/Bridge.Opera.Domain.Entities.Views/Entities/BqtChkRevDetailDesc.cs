namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BqtChkRevDetailDesc
{
    public decimal? BbId { get; set; }
    public string PgBrk { get; set; }
    public DateTime? EventStartDate { get; set; }
    public string NameDescription { get; set; }
    public decimal? Quantity { get; set; }
    public decimal? UnitPrice { get; set; }
    public decimal? GrossAmount { get; set; }
    public string TransactionType { get; set; }
    public decimal? EventId { get; set; }
    public string ProgrammeDescription { get; set; }
    public string OrderBy { get; set; }
    public string CurrencyCode { get; set; }
    public decimal? ReportId { get; set; }
    public decimal? OrderByMaster { get; set; }
    public decimal? OrderByDetails { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BqtChkRevDetailDesc>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BQT_CHK_REV_DETAIL_DESC");

            entity.Property(e => e.BbId)
                .HasColumnName("BB_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventStartDate)
                .HasColumnName("EVENT_START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.GrossAmount)
                .HasColumnName("GROSS_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameDescription)
                .HasColumnName("NAME_DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.OrderByDetails)
                .HasColumnName("ORDER_BY_DETAILS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderByMaster)
                .HasColumnName("ORDER_BY_MASTER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PgBrk)
                .HasColumnName("PG_BRK")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ProgrammeDescription)
                .HasColumnName("PROGRAMME_DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReportId)
                .HasColumnName("REPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TransactionType)
                .HasColumnName("TRANSACTION_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.UnitPrice)
                .HasColumnName("UNIT_PRICE")
                .HasColumnType("NUMBER");
        });
	}
}
