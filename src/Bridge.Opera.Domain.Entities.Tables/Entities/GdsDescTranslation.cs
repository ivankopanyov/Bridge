namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsDescTranslation
{
    public decimal TranslationId { get; set; }
    public string GdsHost { get; set; }
    public string Resort { get; set; }
    public string LanguageCode { get; set; }
    public string CodeType { get; set; }
    public string Code1 { get; set; }
    public string Code2 { get; set; }
    public string Code3 { get; set; }
    public string Code4 { get; set; }
    public string TranslatedColumn { get; set; }
    public string Description { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsDescTranslation>(entity =>
        {
            entity.HasKey(e => e.TranslationId)
                .HasName("GDS_DESC_TRANSLATION_PK");

            entity.ToTable("GDS_DESC_TRANSLATION");

            entity.HasIndex(e => e.CodeType)
                .HasName("GDS_TRANS_CODE_TYPE_IND");

            entity.HasIndex(e => new { e.Resort, e.CodeType, e.Code1, e.TranslatedColumn, e.LanguageCode })
                .HasName("GDS_DESC_TRANSLATION_IND");

            entity.Property(e => e.TranslationId)
                .HasColumnName("TRANSLATION_ID")
                .HasColumnType("NUMBER(30)");

            entity.Property(e => e.Code1)
                .IsRequired()
                .HasColumnName("CODE1")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Code2)
                .HasColumnName("CODE2")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Code3)
                .HasColumnName("CODE3")
                .HasMaxLength(30)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Code4)
                .HasColumnName("CODE4")
                .HasMaxLength(30)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CodeType)
                .IsRequired()
                .HasColumnName("CODE_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.GdsHost)
                .HasColumnName("GDS_HOST")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER(20)");

            entity.Property(e => e.LanguageCode)
                .IsRequired()
                .HasColumnName("LANGUAGE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TranslatedColumn)
                .HasColumnName("TRANSLATED_COLUMN")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER(20)");
        });
	}
}
