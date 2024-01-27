namespace Bridge.Opera.Domain.Entities.Tables;

public partial class DevHelpMapping
{
    public string BlockName { get; set; }
    public string FieldName { get; set; }
    public string FormName { get; set; }
    public string PathTopicId { get; set; }
    public string SubTopicName { get; set; }
    public string Notes { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string Version { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DevHelpMapping>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("DEV_HELP_MAPPING");

            entity.HasIndex(e => new { e.Version, e.FormName })
                .HasName("DEVHELPMAP_VERSION_IDX");

            entity.HasIndex(e => new { e.FormName, e.BlockName, e.FieldName, e.SubTopicName, e.PathTopicId, e.Version })
                .HasName("DEVHELPMAP_UK")
                .IsUnique();

            entity.Property(e => e.BlockName)
                .HasColumnName("BLOCK_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.FieldName)
                .HasColumnName("FIELD_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.FormName)
                .HasColumnName("FORM_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Notes)
                .HasColumnName("NOTES")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.PathTopicId)
                .HasColumnName("PATH_TOPIC_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SubTopicName)
                .HasColumnName("SUB_TOPIC_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Version)
                .HasColumnName("VERSION")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
