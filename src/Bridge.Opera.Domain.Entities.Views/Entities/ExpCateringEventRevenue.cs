namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpCateringEventRevenue
{
    public decimal? RecordType { get; set; }
    public string? SourceSystem { get; set; }
    public string? PropertyCode { get; set; }
    public string? TransactionType { get; set; }
    public decimal? BookId { get; set; }
    public string? Udfc06 { get; set; }
    public decimal? EventId { get; set; }
    public string? RevenueType { get; set; }
    public string? RevenueGroup { get; set; }
    public decimal? CurrForRevNet { get; set; }
    public decimal? CurrForRevGross { get; set; }
    public decimal? CurrGtdRevNet { get; set; }
    public decimal? CurrGtdRevGross { get; set; }
    public decimal? CurrExpRevNet { get; set; }
    public decimal? CurrExpRevGross { get; set; }
    public decimal? CurrActRevNet { get; set; }
    public decimal? CurrActRevGross { get; set; }
    public string? ExtEventId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpCateringEventRevenue>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_CATERING_EVENT_REVENUE");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrActRevGross)
                .HasColumnName("CURR_ACT_REV_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrActRevNet)
                .HasColumnName("CURR_ACT_REV_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrExpRevGross)
                .HasColumnName("CURR_EXP_REV_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrExpRevNet)
                .HasColumnName("CURR_EXP_REV_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrForRevGross)
                .HasColumnName("CURR_FOR_REV_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrForRevNet)
                .HasColumnName("CURR_FOR_REV_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrGtdRevGross)
                .HasColumnName("CURR_GTD_REV_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrGtdRevNet)
                .HasColumnName("CURR_GTD_REV_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExtEventId)
                .HasColumnName("EXT_EVENT_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PropertyCode)
                .HasColumnName("PROPERTY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevenueGroup)
                .HasColumnName("REVENUE_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevenueType)
                .HasColumnName("REVENUE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceSystem)
                .HasColumnName("SOURCE_SYSTEM")
                .HasColumnType("CHAR(5)");

            entity.Property(e => e.TransactionType)
                .HasColumnName("TRANSACTION_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.Udfc06)
                .HasColumnName("UDFC06")
                .HasMaxLength(15)
                .IsUnicode(false);
        });
	}
}
