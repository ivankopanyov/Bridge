namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiRateCodeDim
{
    public string? AllCode { get; set; }
    public string? AllDesc { get; set; }
    public string? Resort { get; set; }
    public string? RateCode { get; set; }
    public string? Description { get; set; }
    public string? RateCodeLocked { get; set; }
    public DateTime? InactiveDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiRateCodeDim>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_RATE_CODE_DIM");

            entity.Property(e => e.AllCode)
                .HasColumnName("ALL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .IsUnicode(false);

            entity.Property(e => e.RateCodeLocked)
                .HasColumnName("RATE_CODE_LOCKED")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .IsUnicode(false);
        });
	}
}
