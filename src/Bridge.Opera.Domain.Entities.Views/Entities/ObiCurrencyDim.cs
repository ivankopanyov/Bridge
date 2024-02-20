namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiCurrencyDim
{
    public string? AllCode { get; set; }
    public string? AllDesc { get; set; }
    public string? CurrencyCode { get; set; }
    public string? Description { get; set; }
    public string? FormatMask { get; set; }
    public decimal? DecimalPositions { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiCurrencyDim>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_CURRENCY_DIM");

            entity.Property(e => e.AllCode)
                .HasColumnName("ALL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .IsUnicode(false);

            entity.Property(e => e.DecimalPositions)
                .HasColumnName("DECIMAL_POSITIONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.FormatMask)
                .HasColumnName("FORMAT_MASK")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
