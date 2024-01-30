namespace Bridge.Opera.Domain.Entities.Tables;

public partial class DatamartStat
{
    public string? Resort { get; set; }
    public string? StatType { get; set; }
    public DateTime? StatDate { get; set; }
    public decimal? TotalMessages { get; set; }
    public decimal? TotalSuccess { get; set; }
    public decimal? TotalFailed { get; set; }
    public decimal? TotalSuspended { get; set; }
    public DateTime? LastUpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DatamartStat>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.StatType, e.StatDate })
                .HasName("DATAMART_STAT_PK");

            entity.ToTable("DATAMART_STAT");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StatType)
                .HasColumnName("STAT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StatDate)
                .HasColumnName("STAT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LastUpdateDate)
                .HasColumnName("LAST_UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TotalFailed)
                .HasColumnName("TOTAL_FAILED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalMessages)
                .HasColumnName("TOTAL_MESSAGES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalSuccess)
                .HasColumnName("TOTAL_SUCCESS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalSuspended)
                .HasColumnName("TOTAL_SUSPENDED")
                .HasColumnType("NUMBER");
        });
	}
}
