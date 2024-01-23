namespace Bridge.Opera.Domain.Entities.Tables;

public partial class O2hMigrations
{
    public string MigrationId { get; set; }
    public string MigrationPhase { get; set; }
    public string MigrationStatus { get; set; }
    public string MigrationStep { get; set; }
    public decimal? MigratedRows { get; set; }
    public string TargetChainCode { get; set; }
    public string AutoContinueYn { get; set; }
    public string AppVersion { get; set; }
    public string Dblink { get; set; }
    public DateTime? CutoffDate { get; set; }
    public string StopOnErrorYn { get; set; }
    public string ProcId { get; set; }
    public string SourceSchema { get; set; }
    public string SourceServiceName { get; set; }
    public string SourcePortNo { get; set; }
    public string SourceHost { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public string SourceChainCode { get; set; }
    public string SourceResort { get; set; }
    public string AllProfilesYn { get; set; }
    public string ProfilesQuery { get; set; }
    public string MigrateSidYn { get; set; }
    public string LastKey { get; set; }
    public string DebugYn { get; set; }
    public DateTime? SourceChainDate { get; set; }
    public string OriginalMigrationId { get; set; }
    public DateTime? BusinessDate { get; set; }
    public DateTime? StartDate { get; set; }
    public decimal? NoOfRestarts { get; set; }
    public string CodeConversionYn { get; set; }
    public string ShareProfilesYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<O2hMigrations>(entity =>
        {
            entity.HasKey(e => e.MigrationId)
                .HasName("O2H_MIGRATIONS_PK");

            entity.ToTable("O2H_MIGRATIONS");

            entity.Property(e => e.MigrationId)
                .HasColumnName("MIGRATION_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AllProfilesYn)
                .HasColumnName("ALL_PROFILES_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AppVersion)
                .HasColumnName("APP_VERSION")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.AutoContinueYn)
                .HasColumnName("AUTO_CONTINUE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CodeConversionYn)
                .HasColumnName("CODE_CONVERSION_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CutoffDate)
                .HasColumnName("CUTOFF_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Dblink)
                .HasColumnName("DBLINK")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.DebugYn)
                .HasColumnName("DEBUG_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastKey)
                .HasColumnName("LAST_KEY")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.MigrateSidYn)
                .HasColumnName("MIGRATE_SID_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MigratedRows)
                .HasColumnName("MIGRATED_ROWS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MigrationPhase)
                .HasColumnName("MIGRATION_PHASE")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.MigrationStatus)
                .HasColumnName("MIGRATION_STATUS")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.MigrationStep)
                .HasColumnName("MIGRATION_STEP")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.NoOfRestarts)
                .HasColumnName("NO_OF_RESTARTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OriginalMigrationId)
                .HasColumnName("ORIGINAL_MIGRATION_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ProcId)
                .HasColumnName("PROC_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ProfilesQuery)
                .HasColumnName("PROFILES_QUERY")
                .IsUnicode(false);

            entity.Property(e => e.ShareProfilesYn)
                .HasColumnName("SHARE_PROFILES_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SourceChainCode)
                .HasColumnName("SOURCE_CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceChainDate)
                .HasColumnName("SOURCE_CHAIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.SourceHost)
                .HasColumnName("SOURCE_HOST")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SourcePortNo)
                .HasColumnName("SOURCE_PORT_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceResort)
                .HasColumnName("SOURCE_RESORT")
                .IsUnicode(false);

            entity.Property(e => e.SourceSchema)
                .IsRequired()
                .HasColumnName("SOURCE_SCHEMA")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.SourceServiceName)
                .HasColumnName("SOURCE_SERVICE_NAME")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.StopOnErrorYn)
                .HasColumnName("STOP_ON_ERROR_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TargetChainCode)
                .HasColumnName("TARGET_CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
