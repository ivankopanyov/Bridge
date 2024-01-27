namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsCompetitorDataLog
{
    public decimal RecordId { get; set; }
    public decimal RequestId { get; set; }
    public DateTime RequestDate { get; set; }
    public string Resort { get; set; }
    public string ShopperCode { get; set; }
    public string CompetitorResort { get; set; }
    public string TravelsiteCode { get; set; }
    public DateTime ArrivalDate { get; set; }
    public decimal Los { get; set; }
    public string TravelsiteRateCode { get; set; }
    public string TravelsiteRoomtypeCode { get; set; }
    public string AvailabilityStatus { get; set; }
    public decimal? Amount1 { get; set; }
    public decimal InsertUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsCompetitorDataLog>(entity =>
        {
            entity.HasKey(e => e.RecordId)
                .HasName("ORMS_COMP_DATA_LOG_PK");

            entity.ToTable("ORMS_COMPETITOR_DATA_LOG");

            entity.Property(e => e.RecordId)
                .HasColumnName("RECORD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Amount1)
                .HasColumnName("AMOUNT_1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalDate)
                .HasColumnName("ARRIVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AvailabilityStatus)
                .IsRequired()
                .HasColumnName("AVAILABILITY_STATUS")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.CompetitorResort)
                .IsRequired()
                .HasColumnName("COMPETITOR_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Los)
                .HasColumnName("LOS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RequestDate)
                .HasColumnName("REQUEST_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RequestId)
                .HasColumnName("REQUEST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ShopperCode)
                .IsRequired()
                .HasColumnName("SHOPPER_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TravelsiteCode)
                .IsRequired()
                .HasColumnName("TRAVELSITE_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TravelsiteRateCode)
                .IsRequired()
                .HasColumnName("TRAVELSITE_RATE_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TravelsiteRoomtypeCode)
                .IsRequired()
                .HasColumnName("TRAVELSITE_ROOMTYPE_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
