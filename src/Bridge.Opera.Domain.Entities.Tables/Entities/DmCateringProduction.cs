namespace Bridge.Opera.Domain.Entities.Tables;

public partial class DmCateringProduction
{
    public string? Resort { get; set; }
    public decimal? BookId { get; set; }
    public decimal? EventId { get; set; }
    public string? EventStatus { get; set; }
    public string? EventType { get; set; }
    public DateTime? EventStartDate { get; set; }
    public DateTime? EventEndDate { get; set; }
    public string? EventSpace { get; set; }
    public string? CoverableYn { get; set; }
    public decimal? ChangeId { get; set; }
    public DateTime? ChangeDate { get; set; }
    public string? ChangeEventStatus { get; set; }
    public decimal? ChangeAttendees { get; set; }
    public decimal? ChangeCatSrep { get; set; }
    public string? ChangeCatSrepResort { get; set; }
    public decimal? ChangeRevenue { get; set; }
    public string? ChangeRevenueType { get; set; }
    public string? ChangeRevenueByPkgYn { get; set; }
    public string? CatCurrency { get; set; }
    public string? PropertyCurrency { get; set; }
    public decimal? ExchangeRate { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? DmProcessed { get; set; }
    public string? DmProcessedYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DmCateringProduction>(entity =>
        {
            entity.HasKey(e => e.ChangeId)
                .HasName("DM_CAT_PROD_PK");

            entity.ToTable("DM_CATERING_PRODUCTION");

            entity.HasIndex(e => new { e.DmProcessedYn, e.Resort, e.InsertDate })
                .HasName("DM_CAT_PROD_PROCESSED_IDX");

            entity.Property(e => e.ChangeId)
                .HasColumnName("CHANGE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CatCurrency)
                .HasColumnName("CAT_CURRENCY")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.ChangeAttendees)
                .HasColumnName("CHANGE_ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChangeCatSrep)
                .HasColumnName("CHANGE_CAT_SREP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChangeCatSrepResort)
                .HasColumnName("CHANGE_CAT_SREP_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ChangeDate)
                .HasColumnName("CHANGE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ChangeEventStatus)
                .HasColumnName("CHANGE_EVENT_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.ChangeRevenue)
                .HasColumnName("CHANGE_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChangeRevenueByPkgYn)
                .HasColumnName("CHANGE_REVENUE_BY_PKG_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ChangeRevenueType)
                .IsRequired()
                .HasColumnName("CHANGE_REVENUE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CoverableYn)
                .HasColumnName("COVERABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DmProcessed)
                .HasColumnName("DM_PROCESSED")
                .HasColumnType("DATE");

            entity.Property(e => e.DmProcessedYn)
                .HasColumnName("DM_PROCESSED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EventEndDate)
                .HasColumnName("EVENT_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventSpace)
                .HasColumnName("EVENT_SPACE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EventStartDate)
                .HasColumnName("EVENT_START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EventStatus)
                .HasColumnName("EVENT_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.EventType)
                .IsRequired()
                .HasColumnName("EVENT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PropertyCurrency)
                .HasColumnName("PROPERTY_CURRENCY")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
