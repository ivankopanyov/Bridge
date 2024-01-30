namespace Bridge.Opera.Domain.Entities.Tables;

public partial class Us1099Periods
{
    public decimal? PeriodId { get; set; }
    public string? Resort { get; set; }
    public string? Period { get; set; }
    public string? RecipientType { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public string? FilingMode { get; set; }
    public DateTime? FirstSentDate { get; set; }
    public decimal? SentCount { get; set; }
    public DateTime? LastSentDate { get; set; }
    public string? FileStatus { get; set; }
    public string? CorrectionRefFile { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Us1099Periods>(entity =>
        {
            entity.HasKey(e => e.PeriodId)
                .HasName("US_1099_PERIODS_PK");

            entity.ToTable("US_1099_PERIODS");

            entity.HasIndex(e => new { e.Resort, e.Period, e.RecipientType })
                .HasName("US_1099_PERIODS_UK")
                .IsUnique();

            entity.Property(e => e.PeriodId)
                .HasColumnName("PERIOD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CorrectionRefFile)
                .HasColumnName("CORRECTION_REF_FILE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FileStatus)
                .HasColumnName("FILE_STATUS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FilingMode)
                .HasColumnName("FILING_MODE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FirstSentDate)
                .HasColumnName("FIRST_SENT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastSentDate)
                .HasColumnName("LAST_SENT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Period)
                .IsRequired()
                .HasColumnName("PERIOD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RecipientType)
                .IsRequired()
                .HasColumnName("RECIPIENT_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SentCount)
                .HasColumnName("SENT_COUNT")
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
