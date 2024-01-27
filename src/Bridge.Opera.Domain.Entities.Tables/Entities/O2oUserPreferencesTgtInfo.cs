namespace Bridge.Opera.Domain.Entities.Tables;

public partial class O2oUserPreferencesTgtInfo
{
    public string O2oMigId { get; set; }
    public string ExternalResort { get; set; }
    public string ProfilesWOMembershipsYn { get; set; }
    public string ExclProfilesMemTypes { get; set; }
    public string SendProfilesFirstYn { get; set; }
    public string OnlyProfilesResvsBlocksAr { get; set; }
    public string NTargetResort { get; set; }
    public string TargetProperty { get; set; }
    public string Resort { get; set; }
    public DateTime? ReservationHistCutoffDate { get; set; }
    public decimal? Prof1StayInLastNDays { get; set; }
    public decimal? ProfAtleastNPrevStays { get; set; }
    public DateTime? ProfLastUpdated { get; set; }
    public DateTime? ActiveStartDate { get; set; }
    public string SendRelatedProfilesFirstYn { get; set; }
    public string MigrationStatus { get; set; }
    public string InclStatisticsYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<O2oUserPreferencesTgtInfo>(entity =>
        {
            entity.HasKey(e => e.O2oMigId)
                .HasName("OUO_PK");

            entity.ToTable("O2O_USER_PREFERENCES_TGT_INFO");

            entity.Property(e => e.O2oMigId)
                .HasColumnName("O2O_MIG_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ActiveStartDate)
                .HasColumnName("ACTIVE_START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExclProfilesMemTypes)
                .HasColumnName("EXCL_PROFILES_MEM_TYPES")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ExternalResort)
                .HasColumnName("EXTERNAL_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InclStatisticsYn)
                .HasColumnName("INCL_STATISTICS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MigrationStatus)
                .HasColumnName("MIGRATION_STATUS")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.NTargetResort)
                .HasColumnName("N_TARGET_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OnlyProfilesResvsBlocksAr)
                .HasColumnName("ONLY_PROFILES_RESVS_BLOCKS_AR")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Prof1StayInLastNDays)
                .HasColumnName("PROF_1_STAY_IN_LAST_N_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProfAtleastNPrevStays)
                .HasColumnName("PROF_ATLEAST_N_PREV_STAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProfLastUpdated)
                .HasColumnName("PROF_LAST_UPDATED")
                .HasColumnType("DATE");

            entity.Property(e => e.ProfilesWOMembershipsYn)
                .HasColumnName("PROFILES_W_O_MEMBERSHIPS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ReservationHistCutoffDate)
                .HasColumnName("RESERVATION_HIST_CUTOFF_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SendProfilesFirstYn)
                .HasColumnName("SEND_PROFILES_FIRST_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SendRelatedProfilesFirstYn)
                .HasColumnName("SEND_RELATED_PROFILES_FIRST_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TargetProperty)
                .HasColumnName("TARGET_PROPERTY")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
