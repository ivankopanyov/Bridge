namespace Bridge.Opera.Domain.Entities.Tables;

public partial class CodeTranslationData
{
    public string FieldName { get; set; }
    public string SourceLanguageCode { get; set; }
    public string SourceValue { get; set; }
    public string TargetLanguageCode { get; set; }
    public string TargetValue { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CodeTranslationData>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("CODE_TRANSLATION_DATA");

            entity.HasIndex(e => new { e.FieldName, e.SourceLanguageCode, e.SourceValue, e.TargetLanguageCode })
                .HasName("CODE_TRANSLATION_DATA_IDX");

            entity.HasIndex(e => new { e.FieldName, e.TargetLanguageCode, e.TargetValue, e.SourceLanguageCode })
                .HasName("CODE_TRANSLATION_DATA_IDX2");

            entity.Property(e => e.FieldName)
                .IsRequired()
                .HasColumnName("FIELD_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceLanguageCode)
                .IsRequired()
                .HasColumnName("SOURCE_LANGUAGE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceValue)
                .IsRequired()
                .HasColumnName("SOURCE_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TargetLanguageCode)
                .IsRequired()
                .HasColumnName("TARGET_LANGUAGE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TargetValue)
                .IsRequired()
                .HasColumnName("TARGET_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
