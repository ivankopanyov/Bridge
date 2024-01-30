namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RevenueTypesTrx1
{
    public decimal? RevTypeTrxId { get; set; }
    public string? EventType { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public string? Location { get; set; }
    public string? Resort { get; set; }
    public string? RevType { get; set; }
    public string? TrxCode { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? CateringOnlyYn { get; set; }
    public string? SvcTrxCode { get; set; }
    public decimal? SvcPct { get; set; }
    public string? SvcCalculationRule { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RevenueTypesTrx1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REVENUE_TYPES_TRX");

            entity.Property(e => e.CateringOnlyYn)
                .HasColumnName("CATERING_ONLY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EventType)
                .HasColumnName("EVENT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Location)
                .HasColumnName("LOCATION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevType)
                .IsRequired()
                .HasColumnName("REV_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevTypeTrxId)
                .HasColumnName("REV_TYPE_TRX_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SvcCalculationRule)
                .HasColumnName("SVC_CALCULATION_RULE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SvcPct)
                .HasColumnName("SVC_PCT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SvcTrxCode)
                .HasColumnName("SVC_TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .IsRequired()
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
