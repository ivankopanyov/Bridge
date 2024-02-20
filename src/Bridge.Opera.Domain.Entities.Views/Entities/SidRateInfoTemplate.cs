namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidRateInfoTemplate
{
    public string? Resort { get; set; }
    public string? LongInfo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidRateInfoTemplate>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_RATE_INFO_TEMPLATE");

            entity.Property(e => e.LongInfo)
                .IsRequired()
                .HasColumnName("LONG_INFO")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
