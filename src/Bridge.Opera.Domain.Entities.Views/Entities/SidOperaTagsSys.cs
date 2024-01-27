namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidOperaTagsSys
{
    public decimal TagId { get; set; }
    public string TagName { get; set; }
    public string MappingColumn { get; set; }
    public string DefaultValue { get; set; }
    public string TagType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidOperaTagsSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_OPERA_TAGS_SYS");

            entity.Property(e => e.DefaultValue)
                .HasColumnName("DEFAULT_VALUE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.MappingColumn)
                .IsRequired()
                .HasColumnName("MAPPING_COLUMN")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.TagId)
                .HasColumnName("TAG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TagName)
                .IsRequired()
                .HasColumnName("TAG_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TagType)
                .HasColumnName("TAG_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
