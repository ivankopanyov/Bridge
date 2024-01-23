namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class GdsResvRateChangeView
{
    public decimal? RateChgAmount { get; set; }
    public string RateChgCurr { get; set; }
    public DateTime? RateChgDate { get; set; }
    public decimal? RateChgExtraAmt { get; set; }
    public decimal? RateChgBedAmt { get; set; }
    public decimal? RateChgChildAmt { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsResvRateChangeView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("GDS_RESV_RATE_CHANGE_VIEW");

            entity.Property(e => e.RateChgAmount)
                .HasColumnName("RATE_CHG_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateChgBedAmt)
                .HasColumnName("RATE_CHG_BED_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateChgChildAmt)
                .HasColumnName("RATE_CHG_CHILD_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateChgCurr)
                .HasColumnName("RATE_CHG_CURR")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.RateChgDate)
                .HasColumnName("RATE_CHG_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RateChgExtraAmt)
                .HasColumnName("RATE_CHG_EXTRA_AMT")
                .HasColumnType("NUMBER");
        });
	}
}
