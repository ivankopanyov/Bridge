namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OrmsPriceSlicesAdvVw
{
    public DateTime? StayDate { get; set; }
    public string? Resort { get; set; }
    public decimal? HeaderId { get; set; }
    public string? YieldCategory { get; set; }
    public decimal? PricesliceId { get; set; }
    public decimal? SliceFrom { get; set; }
    public decimal? SliceTo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsPriceSlicesAdvVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ORMS_PRICE_SLICES_ADV_VW");

            entity.Property(e => e.HeaderId)
                .HasColumnName("HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PricesliceId)
                .HasColumnName("PRICESLICE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SliceFrom)
                .HasColumnName("SLICE_FROM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SliceTo)
                .HasColumnName("SLICE_TO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayDate)
                .HasColumnName("STAY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.YieldCategory)
                .IsRequired()
                .HasColumnName("YIELD_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
