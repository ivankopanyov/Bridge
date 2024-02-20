namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AppLoginLog
{
    public decimal? LogSeqId { get; set; }
    public decimal? AppUserId { get; set; }
    public string? StationId { get; set; }
    public DateTime? LastLoggedTime { get; set; }
    public string? LastLoggedResort { get; set; }
    public decimal? Sid { get; set; }
    public decimal? Serial { get; set; }
    public decimal? InstId { get; set; }
    public string? LoggedTerminals { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AppLoginLog>(entity =>
        {
            entity.HasKey(e => e.LogSeqId)
                .HasName("APP_LOGIN_LOG_PK");

            entity.ToTable("APP_LOGIN_LOG");

            entity.HasIndex(e => e.AppUserId)
                .HasName("APP_LOG_USER_ID_IDX");

            entity.HasIndex(e => e.LastLoggedTime)
                .HasName("APP_LOG_LASTLOG_IDX");

            entity.Property(e => e.LogSeqId)
                .HasColumnName("LOG_SEQ_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AppUserId)
                .HasColumnName("APP_USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InstId)
                .HasColumnName("INST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastLoggedResort)
                .HasColumnName("LAST_LOGGED_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LastLoggedTime)
                .HasColumnName("LAST_LOGGED_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.LoggedTerminals)
                .HasColumnName("LOGGED_TERMINALS")
                .IsUnicode(false);

            entity.Property(e => e.Serial)
                .HasColumnName("SERIAL#")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Sid)
                .HasColumnName("SID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StationId)
                .HasColumnName("STATION_ID")
                .HasMaxLength(64)
                .IsUnicode(false);
        });
	}
}
