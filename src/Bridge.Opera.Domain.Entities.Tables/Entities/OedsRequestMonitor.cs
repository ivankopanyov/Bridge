namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OedsRequestMonitor
{
    public DateTime? RequestDate { get; set; }
    public decimal? RequestProcessTime { get; set; }
    public string? RequestType { get; set; }
    public string? RequestSource { get; set; }
    public decimal? RequestHour { get; set; }
    public string? RequestStatus { get; set; }
    public string? Resort { get; set; }
    public string? Channel { get; set; }
    public DateTime? ArrivalDate { get; set; }
    public decimal? Nights { get; set; }
    public string? AnyId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? P1Char { get; set; }
    public string? P2Char { get; set; }
    public string? P3Char { get; set; }
    public decimal? P1Num { get; set; }
    public decimal? P2Num { get; set; }
    public DateTime? P1Date { get; set; }
    public DateTime? P2Date { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OedsRequestMonitor>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("OEDS_REQUEST_MONITOR");

            entity.Property(e => e.AnyId)
                .HasColumnName("ANY_ID")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.ArrivalDate)
                .HasColumnName("ARRIVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Channel)
                .IsRequired()
                .HasColumnName("CHANNEL")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FirstName)
                .HasColumnName("FIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastName)
                .HasColumnName("LAST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.P1Char)
                .HasColumnName("P1_CHAR")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.P1Date)
                .HasColumnName("P1_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.P1Num)
                .HasColumnName("P1_NUM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.P2Char)
                .HasColumnName("P2_CHAR")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.P2Date)
                .HasColumnName("P2_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.P2Num)
                .HasColumnName("P2_NUM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.P3Char)
                .HasColumnName("P3_CHAR")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RequestDate)
                .HasColumnName("REQUEST_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RequestHour)
                .HasColumnName("REQUEST_HOUR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RequestProcessTime)
                .HasColumnName("REQUEST_PROCESS_TIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RequestSource)
                .HasColumnName("REQUEST_SOURCE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.RequestStatus)
                .HasColumnName("REQUEST_STATUS")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.RequestType)
                .HasColumnName("REQUEST_TYPE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(200)
                .IsUnicode(false);
        });
	}
}
