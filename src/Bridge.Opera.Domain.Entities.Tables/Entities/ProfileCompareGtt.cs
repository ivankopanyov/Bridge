namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ProfileCompareGtt
{
    public decimal? NameId { get; set; }
    public string? RecordType { get; set; }
    public string? NameType { get; set; }
    public string? NameCode { get; set; }
    public string? Sname { get; set; }
    public string? Sfirst { get; set; }
    public string? Sxname { get; set; }
    public string? SxfirstName { get; set; }
    public string? Gender { get; set; }
    public string? ResortRegistered { get; set; }
    public string? ChainCode { get; set; }
    public string? Name2 { get; set; }
    public string? Name3 { get; set; }
    public string? Udfc01 { get; set; }
    public string? Udfc02 { get; set; }
    public string? Udfc03 { get; set; }
    public string? Udfc04 { get; set; }
    public string? Udfc05 { get; set; }
    public string? Udfc06 { get; set; }
    public string? Udfc07 { get; set; }
    public string? Udfc08 { get; set; }
    public string? Udfc09 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ProfileCompareGtt>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("PROFILE_COMPARE_GTT");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
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

            entity.Property(e => e.Udfc01)
                .HasColumnName("UDFC01")
                .IsUnicode(false);

            entity.Property(e => e.Udfc02)
                .HasColumnName("UDFC02")
                .IsUnicode(false);

            entity.Property(e => e.Udfc03)
                .HasColumnName("UDFC03")
                .IsUnicode(false);

            entity.Property(e => e.Udfc04)
                .HasColumnName("UDFC04")
                .IsUnicode(false);

            entity.Property(e => e.Udfc05)
                .HasColumnName("UDFC05")
                .IsUnicode(false);

            entity.Property(e => e.Udfc06)
                .HasColumnName("UDFC06")
                .IsUnicode(false);

            entity.Property(e => e.Udfc07)
                .HasColumnName("UDFC07")
                .IsUnicode(false);

            entity.Property(e => e.Udfc08)
                .HasColumnName("UDFC08")
                .IsUnicode(false);

            entity.Property(e => e.Udfc09)
                .HasColumnName("UDFC09")
                .IsUnicode(false);
        });
	}
}
