namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TranslationOldBackup
{
    public string? TermCode { get; set; }
    public string? TermType { get; set; }
    public string? ObjectName { get; set; }
    public string? Version { get; set; }
    public string? TermText { get; set; }
    public string? TermComment { get; set; }
    public string? LanguageCode { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? CreateDate { get; set; }
    public string? UpdatedBy { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TranslationOldBackup>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("TRANSLATION_OLD_BACKUP");

            entity.HasIndex(e => new { e.LanguageCode, e.ObjectName })
                .HasName("TRANS_FRM_LANG_I");

            entity.HasIndex(e => new { e.ObjectName, e.TermType, e.LanguageCode })
                .HasName("TRANS_OBJ_TT_LAN_IDX");

            entity.HasIndex(e => new { e.TermCode, e.TermType, e.LanguageCode, e.ObjectName })
                .HasName("TRANSLATION_UK")
                .IsUnique();

            entity.Property(e => e.CreateDate)
                .HasColumnName("CREATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CreatedBy)
                .HasColumnName("CREATED_BY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.LanguageCode)
                .IsRequired()
                .HasColumnName("LANGUAGE_CODE")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.ObjectName)
                .HasColumnName("OBJECT_NAME")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TermCode)
                .IsRequired()
                .HasColumnName("TERM_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TermComment)
                .HasColumnName("TERM_COMMENT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TermText)
                .HasColumnName("TERM_TEXT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TermType)
                .IsRequired()
                .HasColumnName("TERM_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdatedBy)
                .HasColumnName("UPDATED_BY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Version)
                .IsRequired()
                .HasColumnName("VERSION")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
