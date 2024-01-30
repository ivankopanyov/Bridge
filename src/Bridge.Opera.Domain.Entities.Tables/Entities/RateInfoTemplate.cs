namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RateInfoTemplate
{
    public string? Resort { get; set; }
    public string? LongInfo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RateInfoTemplate>(entity =>
        {
            entity.HasKey(e => e.Resort)
                .HasName("RATE_INFO_TEMPLATE_PK");

            entity.ToTable("RATE_INFO_TEMPLATE");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LongInfo)
                .IsRequired()
                .HasColumnName("LONG_INFO")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
