namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OperaSsoLog
{
    public decimal LogId { get; set; }
    public string SourceSystemId { get; set; }
    public string TargetSystemId { get; set; }
    public string OperaAppUser { get; set; }
    public DateTime? AccessTs { get; set; }
    public string Token { get; set; }
    public string LandingZone { get; set; }
    public string SuccessYn { get; set; }
    public string FailureReason { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OperaSsoLog>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("OPERA_SSO_LOG");

            entity.HasIndex(e => new { e.SourceSystemId, e.TargetSystemId, e.AccessTs })
                .HasName("OPERA_SSO_LOG_ACCESS_IDX");

            entity.HasIndex(e => new { e.SourceSystemId, e.TargetSystemId, e.OperaAppUser })
                .HasName("OPERA_SSO_LOG_USER_IDX");

            entity.Property(e => e.AccessTs)
                .HasColumnName("ACCESS_TS")
                .HasColumnType("TIMESTAMP(6)");

            entity.Property(e => e.FailureReason)
                .HasColumnName("FAILURE_REASON")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.LandingZone)
                .HasColumnName("LANDING_ZONE")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.LogId)
                .HasColumnName("LOG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OperaAppUser)
                .HasColumnName("OPERA_APP_USER")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SourceSystemId)
                .HasColumnName("SOURCE_SYSTEM_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SuccessYn)
                .HasColumnName("SUCCESS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TargetSystemId)
                .HasColumnName("TARGET_SYSTEM_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Token)
                .HasColumnName("TOKEN")
                .HasMaxLength(200)
                .IsUnicode(false);
        });
	}
}
