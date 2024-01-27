namespace Bridge.Opera.Domain.Entities.Tables;

public partial class NameKeywords
{
    public decimal NameId { get; set; }
    public string Keyword { get; set; }
    public string KeywordSoundex { get; set; }
    public string KeywordType { get; set; }
    public byte? LaptopChange { get; set; }
    public string UpdateAllowedYn { get; set; }
    public string InterfaceUpdatedYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NameKeywords>(entity =>
        {
            entity.HasKey(e => new { e.NameId, e.Keyword, e.KeywordType })
                .HasName("NAME_KEYWORD_PK");

            entity.ToTable("NAME_KEYWORDS");

            entity.HasIndex(e => e.KeywordSoundex)
                .HasName("NAME_KEYWORD_N2");

            entity.HasIndex(e => e.KeywordType)
                .HasName("NAME_KEYWORD_N3");

            entity.HasIndex(e => new { e.Keyword, e.KeywordType, e.NameId })
                .HasName("NAME_KEYWORD_N1");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Keyword)
                .HasColumnName("KEYWORD")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.KeywordType)
                .HasColumnName("KEYWORD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InterfaceUpdatedYn)
                .HasColumnName("INTERFACE_UPDATED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.KeywordSoundex)
                .HasColumnName("KEYWORD_SOUNDEX")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LaptopChange)
                .HasColumnName("LAPTOP_CHANGE")
                .HasColumnType("NUMBER(2)");

            entity.Property(e => e.UpdateAllowedYn)
                .HasColumnName("UPDATE_ALLOWED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
