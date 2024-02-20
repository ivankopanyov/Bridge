namespace Bridge.Opera.Domain.Entities.Tables;

public partial class HelpFileMapping
{
    public string? BlockName { get; set; }
    public string? FieldName { get; set; }
    public string? FormName { get; set; }
    public string? PathTopicId { get; set; }
    public string? SubTopicName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<HelpFileMapping>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("HELP_FILE_MAPPING");

            entity.HasIndex(e => new { e.FormName, e.BlockName, e.FieldName, e.SubTopicName, e.PathTopicId })
                .HasName("FORM_BLOCK_FIELD_UK")
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

            entity.Property(e => e.PathTopicId)
                .HasColumnName("PATH_TOPIC_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SubTopicName)
                .HasColumnName("SUB_TOPIC_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);
        });
	}
}
