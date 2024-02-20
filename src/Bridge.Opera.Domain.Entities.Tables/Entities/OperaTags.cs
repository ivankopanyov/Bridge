namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OperaTags
{
    public decimal? TagId { get; set; }
    public string? TagName { get; set; }
    public string? MappingColumn { get; set; }
    public string? DefaultValue { get; set; }
    public string? TagType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OperaTags>(entity =>
        {
            entity.HasKey(e => e.TagId)
                .HasName("OPERA_TAGS_PK");

            entity.ToTable("OPERA_TAGS");

            entity.HasIndex(e => new { e.TagName, e.TagType })
                .HasName("OPERA_TAGS_UK")
                .IsUnique();

            entity.Property(e => e.TagId)
                .HasColumnName("TAG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DefaultValue)
                .HasColumnName("DEFAULT_VALUE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.MappingColumn)
                .IsRequired()
                .HasColumnName("MAPPING_COLUMN")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.TagName)
                .IsRequired()
                .HasColumnName("TAG_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TagType)
                .HasColumnName("TAG_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'C'");
        });
	}
}
