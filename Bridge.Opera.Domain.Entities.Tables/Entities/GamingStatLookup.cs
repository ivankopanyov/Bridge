namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GamingStatLookup
{
    public string Corrid { get; set; }
    public decimal Rowseq { get; set; }
    public string LabelText { get; set; }
    public string DataValue { get; set; }
    public string DataType { get; set; }
    public string FormatMask { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GamingStatLookup>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("GAMING_STAT_LOOKUP");

            entity.HasIndex(e => new { e.Corrid, e.Rowseq })
                .HasName("GAMING_STAT_LOOKUP_UK")
                .IsUnique();

            entity.Property(e => e.Corrid)
                .IsRequired()
                .HasColumnName("CORRID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DataType)
                .IsRequired()
                .HasColumnName("DATA_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'C'");

            entity.Property(e => e.DataValue)
                .IsRequired()
                .HasColumnName("DATA_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FormatMask)
                .HasColumnName("FORMAT_MASK")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.LabelText)
                .IsRequired()
                .HasColumnName("LABEL_TEXT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Rowseq)
                .HasColumnName("ROWSEQ")
                .HasColumnType("NUMBER");
        });
	}
}
