namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiMappingLabel
{
    public string? RateLabel { get; set; }
    public string? RateLabelDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiMappingLabel>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_MAPPING_LABEL");

            entity.Property(e => e.RateLabel)
                .HasColumnName("RATE_LABEL")
                .HasColumnType("CHAR(4)");

            entity.Property(e => e.RateLabelDesc)
                .HasColumnName("RATE_LABEL_DESC")
                .IsUnicode(false);
        });
	}
}
