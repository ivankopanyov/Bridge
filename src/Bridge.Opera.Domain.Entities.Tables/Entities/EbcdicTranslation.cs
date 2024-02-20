namespace Bridge.Opera.Domain.Entities.Tables;

public partial class EbcdicTranslation
{
    public decimal? EbcdicValue { get; set; }
    public string? Character { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EbcdicTranslation>(entity =>
        {
            entity.HasKey(e => e.Character)
                .HasName("EBCDIC_TRANSLATION_UK1");

            entity.ToTable("EBCDIC_TRANSLATION");

            entity.Property(e => e.Character)
                .HasColumnName("CHARACTER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EbcdicValue)
                .HasColumnName("EBCDIC_VALUE")
                .HasColumnType("NUMBER");
        });
	}
}
