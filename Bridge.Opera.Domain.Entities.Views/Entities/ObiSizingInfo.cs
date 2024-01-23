namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiSizingInfo
{
    public decimal SizingId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Status { get; set; }
    public string Comments { get; set; }
    public string EnvType { get; set; }
    public string EnvTypeDesc { get; set; }
    public decimal? EstDatamartSize { get; set; }
    public decimal? EstTablespaceSize { get; set; }
    public decimal? EstTempsegSize { get; set; }
    public decimal? TotalSize { get; set; }
    public string PCubes { get; set; }
    public string PInactiveDimensions { get; set; }
    public string PResorts { get; set; }
    public decimal? PNoResortsForWhenLive { get; set; }
    public decimal? PFutureStayMonths { get; set; }
    public string PCentralCurrencyYn { get; set; }
    public string PCentralCurrencyCode { get; set; }
    public string PDailySnapshotType { get; set; }
    public string PMonthlySnapshotType { get; set; }
    public string PEventTypes { get; set; }
    public decimal? PObiStartYr { get; set; }
    public decimal? PNoProfiles { get; set; }
    public string JobRunningYn { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiSizingInfo>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_SIZING_INFO");

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EnvType)
                .HasColumnName("ENV_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EnvTypeDesc)
                .HasColumnName("ENV_TYPE_DESC")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.EstDatamartSize)
                .HasColumnName("EST_DATAMART_SIZE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EstTablespaceSize)
                .HasColumnName("EST_TABLESPACE_SIZE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EstTempsegSize)
                .HasColumnName("EST_TEMPSEG_SIZE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.JobRunningYn)
                .HasColumnName("JOB_RUNNING_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PCentralCurrencyCode)
                .HasColumnName("P_CENTRAL_CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PCentralCurrencyYn)
                .HasColumnName("P_CENTRAL_CURRENCY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PCubes)
                .HasColumnName("P_CUBES")
                .IsUnicode(false);

            entity.Property(e => e.PDailySnapshotType)
                .HasColumnName("P_DAILY_SNAPSHOT_TYPE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PEventTypes)
                .HasColumnName("P_EVENT_TYPES")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PFutureStayMonths)
                .HasColumnName("P_FUTURE_STAY_MONTHS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PInactiveDimensions)
                .HasColumnName("P_INACTIVE_DIMENSIONS")
                .IsUnicode(false);

            entity.Property(e => e.PMonthlySnapshotType)
                .HasColumnName("P_MONTHLY_SNAPSHOT_TYPE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PNoProfiles)
                .HasColumnName("P_NO_PROFILES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PNoResortsForWhenLive)
                .HasColumnName("P_NO_RESORTS_FOR_WHEN_LIVE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PObiStartYr)
                .HasColumnName("P_OBI_START_YR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PResorts)
                .HasColumnName("P_RESORTS")
                .IsUnicode(false);

            entity.Property(e => e.SizingId)
                .HasColumnName("SIZING_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Status)
                .IsRequired()
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TotalSize)
                .HasColumnName("TOTAL_SIZE")
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
