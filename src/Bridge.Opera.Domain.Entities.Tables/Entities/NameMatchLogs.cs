namespace Bridge.Opera.Domain.Entities.Tables;

public partial class NameMatchLogs
{
    public decimal? LogId { get; set; }
    public string? ChainCode { get; set; }
    public string? Resort { get; set; }
    public string? NameType { get; set; }
    public DateTime? RunDate { get; set; }
    public decimal? LastNameId { get; set; }
    public DateTime? LastMatchDate { get; set; }
    public string? RuleCode { get; set; }
    public decimal? MatchesFound { get; set; }
    public decimal? ProfilesMerged { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NameMatchLogs>(entity =>
        {
            entity.HasKey(e => e.LogId)
                .HasName("NMLOG_PK");

            entity.ToTable("NAME_MATCH_LOGS");

            entity.HasIndex(e => new { e.ChainCode, e.Resort, e.NameType, e.RunDate })
                .HasName("NAME_MATCH_LOGS_IDX1");

            entity.Property(e => e.LogId)
                .HasColumnName("LOG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastMatchDate)
                .HasColumnName("LAST_MATCH_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LastNameId)
                .HasColumnName("LAST_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MatchesFound)
                .HasColumnName("MATCHES_FOUND")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameType)
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ProfilesMerged)
                .HasColumnName("PROFILES_MERGED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RuleCode)
                .HasColumnName("RULE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RunDate)
                .HasColumnName("RUN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
