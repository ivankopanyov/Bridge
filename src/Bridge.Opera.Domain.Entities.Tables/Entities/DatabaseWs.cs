namespace Bridge.Opera.Domain.Entities.Tables;

public partial class DatabaseWs
{
    public string? DatabaseId { get; set; }
    public string? WsCode { get; set; }
    public string? WsUrl { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? TimeoutSeconds { get; set; }
    public decimal? RetrySeconds { get; set; }
    public DateTime? LastTimeFailed { get; set; }
    public string? CurrentHostVer { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DatabaseWs>(entity =>
        {
            entity.HasKey(e => new { e.DatabaseId, e.WsCode })
                .HasName("DAW_PK");

            entity.ToTable("DATABASE_WS");

            entity.Property(e => e.DatabaseId)
                .HasColumnName("DATABASE_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.WsCode)
                .HasColumnName("WS_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CurrentHostVer)
                .HasColumnName("CURRENT_HOST_VER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LastTimeFailed)
                .HasColumnName("LAST_TIME_FAILED")
                .HasColumnType("DATE");

            entity.Property(e => e.RetrySeconds)
                .HasColumnName("RETRY_SECONDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TimeoutSeconds)
                .HasColumnName("TIMEOUT_SECONDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WsUrl)
                .HasColumnName("WS_URL")
                .IsUnicode(false);
        });
	}
}
