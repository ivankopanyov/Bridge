namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipLevelFoliotext
{
    public string ChainCode { get; set; }
    public string MembershipType { get; set; }
    public string MembershipLevel { get; set; }
    public string Resort { get; set; }
    public string FolioText1 { get; set; }
    public string FolioText2 { get; set; }
    public string FolioText3 { get; set; }
    public string FolioText4 { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipLevelFoliotext>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.MembershipType, e.MembershipLevel, e.Resort })
                .HasName("MEMBERSHIP_LEVEL_FOLIOTEXT_PK");

            entity.ToTable("MEMBERSHIP_LEVEL_FOLIOTEXT");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipLevel)
                .HasColumnName("MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FolioText1)
                .HasColumnName("FOLIO_TEXT1")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.FolioText2)
                .HasColumnName("FOLIO_TEXT2")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.FolioText3)
                .HasColumnName("FOLIO_TEXT3")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.FolioText4)
                .HasColumnName("FOLIO_TEXT4")
                .HasMaxLength(400)
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
