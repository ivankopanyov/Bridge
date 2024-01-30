namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsRateUpdateQueueExternal
{
    public string? Resort { get; set; }
    public string? GdsHost { get; set; }
    public string? GdsRateCode { get; set; }
    public string? GdsRoomCategory { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public string? EchoToken { get; set; }
    public string? Status { get; set; }
    public string? ErrorMessage { get; set; }
    public decimal? RetryCount { get; set; }
    public string? ErrorCode { get; set; }
    public string? SubCode { get; set; }
    public string? OldEchoToken { get; set; }
    public string? ResendYn { get; set; }
    public decimal? ResendCount { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? ActionType { get; set; }
    public decimal? RateTier { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsRateUpdateQueueExternal>(entity =>
        {
            entity.HasKey(e => new { e.GdsHost, e.Resort, e.BeginDate, e.EndDate, e.GdsRateCode, e.GdsRoomCategory, e.EchoToken, e.RateTier })
                .HasName("GDS_RATE_UPD_QUE_EXT_PK");

            entity.ToTable("GDS_RATE_UPDATE_QUEUE_EXTERNAL");

            entity.HasIndex(e => e.EchoToken)
                .HasName("GDS_RATE_UPD_QUE_EXT_IND1");

            entity.HasIndex(e => e.Status)
                .HasName("GDS_RATE_UPD_EXT_IND2");

            entity.Property(e => e.GdsHost)
                .HasColumnName("GDS_HOST")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.GdsRateCode)
                .HasColumnName("GDS_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GdsRoomCategory)
                .HasColumnName("GDS_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EchoToken)
                .HasColumnName("ECHO_TOKEN")
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.Property(e => e.RateTier)
                .HasColumnName("RATE_TIER")
                .HasColumnType("NUMBER")
                .HasDefaultValueSql("-99 ");

            entity.Property(e => e.ActionType)
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ErrorCode)
                .HasColumnName("ERROR_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ErrorMessage)
                .HasColumnName("ERROR_MESSAGE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("TIMESTAMP(2)")
                .HasDefaultValueSql("sysdate ");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .HasDefaultValueSql("uid ");

            entity.Property(e => e.OldEchoToken)
                .HasColumnName("OLD_ECHO_TOKEN")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResendCount)
                .HasColumnName("RESEND_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResendYn)
                .HasColumnName("RESEND_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RetryCount)
                .HasColumnName("RETRY_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SubCode)
                .HasColumnName("SUB_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("TIMESTAMP(2)");
        });
	}
}
