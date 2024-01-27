namespace Bridge.Opera.Domain.Entities.Tables;

public partial class StayProfiles
{
    public decimal StayRecordId { get; set; }
    public string PmsNameId { get; set; }
    public string ProfileRole { get; set; }
    public string PrimaryYn { get; set; }
    public decimal? NameId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StayProfiles>(entity =>
        {
            entity.HasKey(e => new { e.StayRecordId, e.PmsNameId, e.ProfileRole })
                .HasName("STAY_PROFILES_PK");

            entity.ToTable("STAY_PROFILES");

            entity.HasIndex(e => new { e.NameId, e.ProfileRole })
                .HasName("STAY_PROFILES_IDX1");

            entity.HasIndex(e => new { e.PmsNameId, e.ProfileRole })
                .HasName("STAY_PROFILES_IDX2");

            entity.Property(e => e.StayRecordId)
                .HasColumnName("STAY_RECORD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PmsNameId)
                .HasColumnName("PMS_NAME_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ProfileRole)
                .HasColumnName("PROFILE_ROLE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrimaryYn)
                .HasColumnName("PRIMARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
