namespace Bridge.Opera.Domain.Entities.Tables;

public partial class StageStayProfiles
{
    public decimal? StageStayRecordId { get; set; }
    public string? PmsNameId { get; set; }
    public string? ProfileRole { get; set; }
    public string? PrimaryYn { get; set; }
    public decimal? NameId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StageStayProfiles>(entity =>
        {
            entity.HasKey(e => new { e.StageStayRecordId, e.PmsNameId, e.ProfileRole })
                .HasName("STAGE_STAY_PROFILES_PK");

            entity.ToTable("STAGE_STAY_PROFILES");

            entity.Property(e => e.StageStayRecordId)
                .HasColumnName("STAGE_STAY_RECORD_ID")
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
