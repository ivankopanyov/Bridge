namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OrmsPriceSlicesVw
{
    public decimal? PricesliceId { get; set; }
    public string? Resort { get; set; }
    public string? YieldCategory { get; set; }
    public decimal? SliceFrom { get; set; }
    public decimal? SliceTo { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public decimal? SliceFromLimited { get; set; }
    public decimal? SliceToLimited { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsPriceSlicesVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ORMS_PRICE_SLICES_VW");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
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

            entity.Property(e => e.SliceFromLimited)
                .HasColumnName("SLICE_FROM_LIMITED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SliceTo)
                .HasColumnName("SLICE_TO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SliceToLimited)
                .HasColumnName("SLICE_TO_LIMITED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YieldCategory)
                .IsRequired()
                .HasColumnName("YIELD_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
