namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipProfileTypes
{
    public string MembershipType { get; set; }
    public string NameType { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipProfileTypes>(entity =>
        {
            entity.HasKey(e => new { e.MembershipType, e.NameType })
                .HasName("MPE_PK");

            entity.ToTable("MEMBERSHIP_PROFILE_TYPES");

            entity.HasIndex(e => e.NameType)
                .HasName("MEMBERSHIP_PROFILE_IND1");

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameType)
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");
        });
	}
}
