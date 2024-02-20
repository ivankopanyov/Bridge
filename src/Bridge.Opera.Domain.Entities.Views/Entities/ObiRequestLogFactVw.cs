namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiRequestLogFactVw
{
    public string? Resort { get; set; }
    public DateTime? RequestDate { get; set; }
    public DateTime? ArrivalDate { get; set; }
    public string? RequestType { get; set; }
    public string? RequestSource { get; set; }
    public string? InsertUser { get; set; }
    public string? InsertHour { get; set; }
    public decimal? Nights { get; set; }
    public decimal? Rooms { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public decimal? LeadDays { get; set; }
    public decimal? LeadCount { get; set; }
    public decimal? RqSuccess { get; set; }
    public decimal? RqFail { get; set; }
    public decimal? Rcnt { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiRequestLogFactVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_REQUEST_LOG_FACT_VW");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalDate)
                .HasColumnName("ARRIVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertHour)
                .HasColumnName("INSERT_HOUR")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .IsUnicode(false);

            entity.Property(e => e.LeadCount)
                .HasColumnName("LEAD_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LeadDays)
                .HasColumnName("LEAD_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Rcnt)
                .HasColumnName("RCNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RequestDate)
                .HasColumnName("REQUEST_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RequestSource)
                .HasColumnName("REQUEST_SOURCE")
                .IsUnicode(false);

            entity.Property(e => e.RequestType)
                .HasColumnName("REQUEST_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Rooms)
                .HasColumnName("ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RqFail)
                .HasColumnName("RQ_FAIL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RqSuccess)
                .HasColumnName("RQ_SUCCESS")
                .HasColumnType("NUMBER");
        });
	}
}
