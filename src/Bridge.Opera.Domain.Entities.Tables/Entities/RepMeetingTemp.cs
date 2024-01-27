namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RepMeetingTemp
{
    public decimal ReportId { get; set; }
    public decimal Id { get; set; }
    public string YTitle { get; set; }
    public decimal? XLength { get; set; }
    public string Color { get; set; }
    public string Text { get; set; }
    public string Pattern { get; set; }
    public string PrintYn { get; set; }
    public string Waitlist { get; set; }
    public DateTime? BeginDate { get; set; }
    public byte? ShortName { get; set; }
    public string RoomResort { get; set; }
    public bool? Part { get; set; }
    public string LineStartYn { get; set; }
    public string HeaderYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepMeetingTemp>(entity =>
        {
            entity.HasKey(e => new { e.ReportId, e.Id })
                .HasName("RMTMP_PK");

            entity.ToTable("REP_MEETING_TEMP");

            entity.Property(e => e.ReportId)
                .HasColumnName("REPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Color)
                .HasColumnName("COLOR")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.HeaderYn)
                .HasColumnName("HEADER_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.LineStartYn)
                .HasColumnName("LINE_START_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Part)
                .HasColumnName("PART")
                .HasDefaultValueSql(@"1");

            entity.Property(e => e.Pattern)
                .HasColumnName("PATTERN")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PrintYn)
                .HasColumnName("PRINT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RoomResort)
                .HasColumnName("ROOM_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ShortName).HasColumnName("SHORT_NAME");

            entity.Property(e => e.Text)
                .HasColumnName("TEXT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Waitlist)
                .HasColumnName("WAITLIST")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.XLength)
                .HasColumnName("X_LENGTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YTitle)
                .HasColumnName("Y_TITLE")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
