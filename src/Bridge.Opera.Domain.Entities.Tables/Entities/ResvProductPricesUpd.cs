namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResvProductPricesUpd
{
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResvProductPricesUpd>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ResvNameId })
                .HasName("RESV_PRODUCT_PRICES_UPD_PK");

            entity.ToTable("RESV_PRODUCT_PRICES_UPD");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");
        });
	}
}
