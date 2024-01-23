namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class GdsRateChangeView
{
    public decimal? RateChgAmount { get; set; }
    public decimal? RateChgExtraAmount { get; set; }
    public decimal? RateChgChildAmount { get; set; }
    public DateTime? RateChgDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsRateChangeView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("GDS_RATE_CHANGE_VIEW");

            entity.Property(e => e.RateChgAmount)
                .HasColumnName("RATE_CHG_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateChgChildAmount)
                .HasColumnName("RATE_CHG_CHILD_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateChgDate)
                .HasColumnName("RATE_CHG_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RateChgExtraAmount)
                .HasColumnName("RATE_CHG_EXTRA_AMOUNT")
                .HasColumnType("NUMBER");
        });
	}
}
