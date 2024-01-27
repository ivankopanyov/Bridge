namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class PrHistoryResvDailyStats
{
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public decimal? ProfileNameId { get; set; }
    public string ProfileNameType { get; set; }
    public string ProfileContactYn { get; set; }
    public DateTime? ProfileBeginDate { get; set; }
    public DateTime? ProfileEndDate { get; set; }
    public string ResvStatus { get; set; }
    public DateTime? ResArrival { get; set; }
    public DateTime? ResDeparture { get; set; }
    public decimal? ResNights { get; set; }
    public DateTime? ReservationDate { get; set; }
    public string ResDayUseYn { get; set; }
    public decimal? ProfileNights { get; set; }
    public decimal? IsPrimaryFlag { get; set; }
    public string CountNightYn { get; set; }
    public string PsuedoYn { get; set; }
    public string CountDayusenightYn { get; set; }
    public decimal? TotalRevenue { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? FbRevenue { get; set; }
    public decimal? OtherRevenue { get; set; }
    public decimal? NonRevenue { get; set; }
    public decimal? NightsRooms { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PrHistoryResvDailyStats>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PR_HISTORY_RESV_DAILY_STATS");

            entity.Property(e => e.CountDayusenightYn)
                .HasColumnName("COUNT_DAYUSENIGHT_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.CountNightYn)
                .HasColumnName("COUNT_NIGHT_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.FbRevenue)
                .HasColumnName("FB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IsPrimaryFlag)
                .HasColumnName("IS_PRIMARY_FLAG")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NightsRooms)
                .HasColumnName("NIGHTS_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NonRevenue)
                .HasColumnName("NON_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenue)
                .HasColumnName("OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProfileBeginDate)
                .HasColumnName("PROFILE_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ProfileContactYn)
                .HasColumnName("PROFILE_CONTACT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ProfileEndDate)
                .HasColumnName("PROFILE_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ProfileNameId)
                .HasColumnName("PROFILE_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProfileNameType)
                .HasColumnName("PROFILE_NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ProfileNights)
                .HasColumnName("PROFILE_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PsuedoYn)
                .HasColumnName("PSUEDO_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ResArrival)
                .HasColumnName("RES_ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.ResDayUseYn)
                .HasColumnName("RES_DAY_USE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ResDeparture)
                .HasColumnName("RES_DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.ResNights)
                .HasColumnName("RES_NIGHTS")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.ReservationDate)
                .HasColumnName("RESERVATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvStatus)
                .IsRequired()
                .HasColumnName("RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER");
        });
	}
}
