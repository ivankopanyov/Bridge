namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidTranslationTrn
{
    public string TermCode { get; set; }
    public string TermType { get; set; }
    public string ObjectName { get; set; }
    public string Version { get; set; }
    public string TermText { get; set; }
    public string TermComment { get; set; }
    public string LanguageCode { get; set; }
    public string CreatedBy { get; set; }
    public DateTime? CreateDate { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidTranslationTrn>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_TRANSLATION_TRN");

            entity.Property(e => e.CreateDate)
                .HasColumnName("CREATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CreatedBy)
                .HasColumnName("CREATED_BY")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.LanguageCode)
                .IsRequired()
                .HasColumnName("LANGUAGE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ObjectName)
                .IsRequired()
                .HasColumnName("OBJECT_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.TermCode)
                .IsRequired()
                .HasColumnName("TERM_CODE")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.TermComment)
                .HasColumnName("TERM_COMMENT")
                .IsUnicode(false);

            entity.Property(e => e.TermText)
                .HasColumnName("TERM_TEXT")
                .IsUnicode(false);

            entity.Property(e => e.TermType)
                .IsRequired()
                .HasColumnName("TERM_TYPE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdatedBy)
                .HasColumnName("UPDATED_BY")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Version)
                .HasColumnName("VERSION")
                .HasMaxLength(200)
                .IsUnicode(false);
        });
	}
}
