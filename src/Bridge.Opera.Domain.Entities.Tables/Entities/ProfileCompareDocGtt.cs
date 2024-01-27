namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ProfileCompareDocGtt
{
    public decimal? NameId { get; set; }
    public string RecordType { get; set; }
    public string NameType { get; set; }
    public string NameCode { get; set; }
    public string Sname { get; set; }
    public string Sfirst { get; set; }
    public string Sxname { get; set; }
    public string SxfirstName { get; set; }
    public string Gender { get; set; }
    public string ResortRegistered { get; set; }
    public string ChainCode { get; set; }
    public string Name2 { get; set; }
    public string Name3 { get; set; }
    public string DocumentType { get; set; }
    public string DocumentRole { get; set; }
    public string DocumentNumber { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ProfileCompareDocGtt>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("PROFILE_COMPARE_DOC_GTT");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DocumentNumber)
                .HasColumnName("DOCUMENT_NUMBER")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.DocumentRole)
                .HasColumnName("DOCUMENT_ROLE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DocumentType)
                .HasColumnName("DOCUMENT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Gender)
                .HasColumnName("GENDER")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Name2)
                .HasColumnName("NAME2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Name3)
                .HasColumnName("NAME3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.NameCode)
                .HasColumnName("NAME_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameType)
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortRegistered)
                .HasColumnName("RESORT_REGISTERED")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Sfirst)
                .HasColumnName("SFIRST")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Sname)
                .HasColumnName("SNAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.SxfirstName)
                .HasColumnName("SXFIRST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Sxname)
                .HasColumnName("SXNAME")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
