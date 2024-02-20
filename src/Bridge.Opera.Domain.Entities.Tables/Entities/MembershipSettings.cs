namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipSettings
{
    public string? ChainCode { get; set; }
    public string? MembershipType { get; set; }
    public string? MembershipLevel { get; set; }
    public string? Type { get; set; }
    public string? Value1 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipSettings>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("MEMBERSHIP_SETTINGS");

            entity.HasIndex(e => new { e.ChainCode, e.MembershipType, e.MembershipLevel, e.Type })
                .HasName("MEM_SET_UK")
                .IsUnique();

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MembershipLevel)
                .HasColumnName("MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MembershipType)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Type)
                .IsRequired()
                .HasColumnName("TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Value1)
                .HasColumnName("VALUE1")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
