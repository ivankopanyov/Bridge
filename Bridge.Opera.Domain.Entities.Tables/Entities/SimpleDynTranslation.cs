namespace Bridge.Opera.Domain.Entities.Tables;

public partial class SimpleDynTranslation
{
    public string ModuleType { get; set; }
    public string ModuleName { get; set; }
    public string ObjectName { get; set; }
    public string TranslationCode { get; set; }
    public string Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SimpleDynTranslation>(entity =>
        {
            entity.HasKey(e => new { e.ModuleType, e.ModuleName, e.ObjectName })
                .HasName("SIMPLE_DYN_TRANS_PK");

            entity.ToTable("SIMPLE_DYN_TRANSLATION");

            entity.Property(e => e.ModuleType)
                .HasColumnName("MODULE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ModuleName)
                .HasColumnName("MODULE_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ObjectName)
                .HasColumnName("OBJECT_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.TranslationCode)
                .HasColumnName("TRANSLATION_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
