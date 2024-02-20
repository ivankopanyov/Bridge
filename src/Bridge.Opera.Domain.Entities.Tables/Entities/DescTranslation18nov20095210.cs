namespace Bridge.Opera.Domain.Entities.Tables;

public partial class DescTranslation18nov20095210
{
    public decimal? TranslationId { get; set; }
    public string? Resort { get; set; }
    public string? LanguageCode { get; set; }
    public string? CodeType { get; set; }
    public string? Code { get; set; }
    public string? TranslatedColumn { get; set; }
    public string? Description { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? CodeGroup { get; set; }
    public string? ChainCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DescTranslation18nov20095210>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("DESC_TRANSLATION_18NOV20095210");

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Code)
                .IsRequired()
                .HasColumnName("CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CodeGroup)
                .HasColumnName("CODE_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CodeType)
                .IsRequired()
                .HasColumnName("CODE_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LanguageCode)
                .IsRequired()
                .HasColumnName("LANGUAGE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TranslatedColumn)
                .HasColumnName("TRANSLATED_COLUMN")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TranslationId)
                .HasColumnName("TRANSLATION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
