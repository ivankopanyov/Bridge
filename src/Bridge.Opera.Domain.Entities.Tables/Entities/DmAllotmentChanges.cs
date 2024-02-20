namespace Bridge.Opera.Domain.Entities.Tables;

public partial class DmAllotmentChanges
{
    public decimal? AllotmentChangeId { get; set; }
    public string? Resort { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public string? AllotmentCode { get; set; }
    public DateTime? ArrivalDate { get; set; }
    public DateTime? StayDate { get; set; }
    public decimal? Roomnights { get; set; }
    public decimal? RoomRevenue { get; set; }
    public string? BookingStatus { get; set; }
    public string? MainSrepResort { get; set; }
    public string? MainSrepCode { get; set; }
    public string? RmsSrepResort { get; set; }
    public string? RmsSrepCode { get; set; }
    public string? CatSrepResort { get; set; }
    public string? CatSrepCode { get; set; }
    public DateTime? DmProcessed { get; set; }
    public string? DmProcessedYn { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DmAllotmentChanges>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.AllotmentChangeId })
                .HasName("DM_ALC_PK");

            entity.ToTable("DM_ALLOTMENT_CHANGES");

            entity.HasIndex(e => new { e.StayDate, e.Resort })
                .HasName("DM_ALC_STAY_DATE_IDX");

            entity.HasIndex(e => new { e.DmProcessedYn, e.Resort, e.InsertDate })
                .HasName("DM_ALC_PROCESSED_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AllotmentChangeId)
                .HasColumnName("ALLOTMENT_CHANGE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentCode)
                .HasColumnName("ALLOTMENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalDate)
                .HasColumnName("ARRIVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BookingStatus)
                .HasColumnName("BOOKING_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CatSrepCode)
                .HasColumnName("CAT_SREP_CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.CatSrepResort)
                .HasColumnName("CAT_SREP_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DmProcessed)
                .HasColumnName("DM_PROCESSED")
                .HasColumnType("DATE");

            entity.Property(e => e.DmProcessedYn)
                .HasColumnName("DM_PROCESSED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MainSrepCode)
                .HasColumnName("MAIN_SREP_CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.MainSrepResort)
                .HasColumnName("MAIN_SREP_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RmsSrepCode)
                .HasColumnName("RMS_SREP_CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.RmsSrepResort)
                .HasColumnName("RMS_SREP_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Roomnights)
                .HasColumnName("ROOMNIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayDate)
                .HasColumnName("STAY_DATE")
                .HasColumnType("DATE");
        });
	}
}
