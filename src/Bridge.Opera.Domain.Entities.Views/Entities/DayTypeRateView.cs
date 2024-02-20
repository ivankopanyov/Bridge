namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class DayTypeRateView
{
    public string? Resort { get; set; }
    public string? RateCode { get; set; }
    public string? DtCode { get; set; }
    public decimal? DisplaySequence { get; set; }
    public string? Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DayTypeRateView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("DAY_TYPE_RATE_VIEW");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DisplaySequence)
                .HasColumnName("DISPLAY_SEQUENCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DtCode)
                .IsRequired()
                .HasColumnName("DT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .IsRequired()
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
