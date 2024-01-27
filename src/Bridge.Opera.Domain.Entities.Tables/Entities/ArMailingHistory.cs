namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ArMailingHistory
{
    public string Resort { get; set; }
    public decimal? AccountCode { get; set; }
    public decimal? SequenceId { get; set; }
    public string ReportFlag { get; set; }
    public string ReportName { get; set; }
    public string InsertUser { get; set; }
    public string InsertDate { get; set; }
    public decimal? ReminderLevel { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArMailingHistory>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("AR$_MAILING_HISTORY");

            entity.HasIndex(e => new { e.Resort, e.AccountCode })
                .HasName("REM_HST_INDX");

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .IsRequired()
                .HasColumnName("INSERT_DATE")
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasDefaultValueSql("sysdate ");

            entity.Property(e => e.InsertUser)
                .IsRequired()
                .HasColumnName("INSERT_USER")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.ReminderLevel)
                .HasColumnName("REMINDER_LEVEL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReportFlag)
                .HasColumnName("REPORT_FLAG")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReportName)
                .HasColumnName("REPORT_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SequenceId)
                .HasColumnName("SEQUENCE_ID")
                .HasColumnType("NUMBER");
        });
	}
}
