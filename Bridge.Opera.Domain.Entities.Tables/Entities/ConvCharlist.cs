namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ConvCharlist
{
    public byte? CharLength { get; set; }
    public byte? ByteLength { get; set; }
    public string ActualChar { get; set; }
    public string ConvertChar { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ConvCharlist>(entity =>
        {
            entity.HasKey(e => e.ActualChar)
                .HasName("PK_COV_CHARLIST");

            entity.ToTable("CONV_CHARLIST");

            entity.Property(e => e.ActualChar)
                .HasColumnName("ACTUAL_CHAR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ByteLength).HasColumnName("BYTE_LENGTH");

            entity.Property(e => e.CharLength).HasColumnName("CHAR_LENGTH");

            entity.Property(e => e.ConvertChar)
                .HasColumnName("CONVERT_CHAR")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
