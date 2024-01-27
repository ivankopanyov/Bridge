namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiAwCubeDefinitionVw
{
    public string SchemaName { get; set; }
    public string AwName { get; set; }
    public string CubeName { get; set; }
    public string ActiveYn { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string RepeatInterval { get; set; }
    public string RebuildYn { get; set; }
    public decimal? EstimatedSize { get; set; }
    public DateTime? EstimationDate { get; set; }
    public DateTime? StartTime { get; set; }
    public DateTime? RefreshTs { get; set; }
    public decimal? DailyBuildProcs { get; set; }
    public decimal? FullBuildProcs { get; set; }
    public decimal? MaxBuildTime { get; set; }
    public decimal? RebuildDays { get; set; }
    public decimal? TempInsertRowLimit { get; set; }
    public decimal? DailyResubmitMins { get; set; }
    public decimal? FullResubmitMins { get; set; }
    public string IncludeForecastYn { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string SelectHint { get; set; }
    public decimal? MaxLoadProcs { get; set; }
    public DateTime? LastCacheClearTime { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiAwCubeDefinitionVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_AW_CUBE_DEFINITION_VW");

            entity.Property(e => e.ActiveYn)
                .HasColumnName("ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AwName)
                .IsRequired()
                .HasColumnName("AW_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.CubeName)
                .IsRequired()
                .HasColumnName("CUBE_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.DailyBuildProcs)
                .HasColumnName("DAILY_BUILD_PROCS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DailyResubmitMins)
                .HasColumnName("DAILY_RESUBMIT_MINS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EstimatedSize)
                .HasColumnName("ESTIMATED_SIZE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EstimationDate)
                .HasColumnName("ESTIMATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FullBuildProcs)
                .HasColumnName("FULL_BUILD_PROCS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FullResubmitMins)
                .HasColumnName("FULL_RESUBMIT_MINS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IncludeForecastYn)
                .HasColumnName("INCLUDE_FORECAST_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastCacheClearTime)
                .HasColumnName("LAST_CACHE_CLEAR_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.MaxBuildTime)
                .HasColumnName("MAX_BUILD_TIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxLoadProcs)
                .HasColumnName("MAX_LOAD_PROCS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RebuildDays)
                .HasColumnName("REBUILD_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RebuildYn)
                .HasColumnName("REBUILD_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RefreshTs)
                .HasColumnName("REFRESH_TS")
                .HasColumnType("DATE");

            entity.Property(e => e.RepeatInterval)
                .HasColumnName("REPEAT_INTERVAL")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.SchemaName)
                .IsRequired()
                .HasColumnName("SCHEMA_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.SelectHint)
                .HasColumnName("SELECT_HINT")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.StartTime)
                .HasColumnName("START_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.TempInsertRowLimit)
                .HasColumnName("TEMP_INSERT_ROW_LIMIT")
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
