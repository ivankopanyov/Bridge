namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class QbKeywords
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
		modelBuilder.Entity<QbKeywords>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("QB_KEYWORDS");

            entity.Property(e => e.InterfaceUpdatedYn)
                .HasColumnName("INTERFACE_UPDATED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Keyword)
                .IsRequired()
                .HasColumnName("KEYWORD")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.KeywordSoundex)
                .HasColumnName("KEYWORD_SOUNDEX")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.KeywordType)
                .IsRequired()
                .HasColumnName("KEYWORD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LaptopChange)
                .HasColumnName("LAPTOP_CHANGE")
                .HasColumnType("NUMBER(2)");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateAllowedYn)
                .HasColumnName("UPDATE_ALLOWED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
