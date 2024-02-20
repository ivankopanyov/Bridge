namespace Bridge.Opera.Domain.Entities.Tables;

public partial class PhoneTypeLanguages
{
    public string? ChainCode { get; set; }
    public string? PhoneType { get; set; }
    public string? LanguageCode { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PhoneTypeLanguages>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.PhoneType, e.LanguageCode })
                .HasName("PHONE_TYPE_LANG_PK");

            entity.ToTable("PHONE_TYPE_LANGUAGES");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PhoneType)
                .HasColumnName("PHONE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LanguageCode)
                .HasColumnName("LANGUAGE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
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
