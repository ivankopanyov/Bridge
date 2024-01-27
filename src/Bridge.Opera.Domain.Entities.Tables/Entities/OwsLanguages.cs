namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OwsLanguages
{
    public string ChainCode { get; set; }
    public string LanguageCode { get; set; }
    public string FlagFilename { get; set; }
    public decimal FlagOrder { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OwsLanguages>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.LanguageCode })
                .HasName("OWS_LANGUAGES_PK");

            entity.ToTable("OWS_LANGUAGES");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LanguageCode)
                .HasColumnName("LANGUAGE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FlagFilename)
                .IsRequired()
                .HasColumnName("FLAG_FILENAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FlagOrder)
                .HasColumnName("FLAG_ORDER")
                .HasColumnType("NUMBER");

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
