namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpConStatRev
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? StatGrpId { get; set; }
    public decimal? StatId { get; set; }
    public decimal? Amount { get; set; }
    public string StatAppSetCode { get; set; }
    public string RevenueCatCode { get; set; }
    public string Currency { get; set; }
    public DateTime? BusinessDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpConStatRev>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_CON_STAT_REV");

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Currency)
                .HasColumnName("CURRENCY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevenueCatCode)
                .HasColumnName("REVENUE_CAT_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.StatAppSetCode)
                .HasColumnName("STAT_APP_SET_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.StatGrpId)
                .HasColumnName("STAT_GRP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StatId)
                .HasColumnName("STAT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
