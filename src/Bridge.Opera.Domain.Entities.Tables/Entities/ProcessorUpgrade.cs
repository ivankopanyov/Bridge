namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ProcessorUpgrade
{
    public string Name { get; set; }
    public byte[] Image { get; set; }
    public DateTime ImageDate { get; set; }
    public decimal ImageSize { get; set; }
    public string ImageVersion { get; set; }
    public string CompressedYn { get; set; }
    public DateTime InsertDate { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal? CompressedSize { get; set; }
    public decimal? Crc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ProcessorUpgrade>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("PROCESSOR_UPGRADE");

            entity.HasIndex(e => e.Name)
                .HasName("PROCESSOR_UPGRADE_UK_NAME")
                .IsUnique();

            entity.Property(e => e.CompressedSize)
                .HasColumnName("COMPRESSED_SIZE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompressedYn)
                .IsRequired()
                .HasColumnName("COMPRESSED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Crc)
                .HasColumnName("CRC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Image)
                .IsRequired()
                .HasColumnName("IMAGE")
                .HasColumnType("BLOB");

            entity.Property(e => e.ImageDate)
                .HasColumnName("IMAGE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ImageSize)
                .HasColumnName("IMAGE_SIZE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ImageVersion)
                .IsRequired()
                .HasColumnName("IMAGE_VERSION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .HasDefaultValueSql("sysdate ");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .HasDefaultValueSql("sysdate ");
        });
	}
}
